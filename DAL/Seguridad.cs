using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace DAL
{
    public class Seguridad
    {
        public static string EncriptarNR(string str)
        {
            //Encriptado NO reversible
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public static string Encriptar(string str, string Key, string IV)
        {
            //Recibo el string a encriptar, la clave y el vector de inicialización

            // Creo una array de bytes
            byte[] encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(Key);
                aesAlg.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);

                // Proceso de encriptacion
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            swEncrypt.Write(str);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(encrypted);

        }

        public static string Desencriptar(string encripted, string Key, string IV)
        {

            string cadenaDesencriptada = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(Key);
                aesAlg.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);

                //Desencripto
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                byte[] cipher = Convert.FromBase64String(encripted);

                using (MemoryStream msDecrypt = new MemoryStream(cipher))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            cadenaDesencriptada = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return cadenaDesencriptada;

        }
    }
}
