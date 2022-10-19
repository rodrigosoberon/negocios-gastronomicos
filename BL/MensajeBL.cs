using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    public class MensajeBL
    {

        //Harcodeado idioma del usuario
        public string idiomaUsuario = "en";
        

        public List<Mensaje> Listar()
        {
            return MensajeDAL.Listar(idiomaUsuario);
        }

        public DataTable ObtenerTraducciones()
        {
            //Devuelve un DataTable con las traducciones del idioma del usuario
            DataTable mMensajes = new DataTable();
            DataColumn IdMensaje = new DataColumn("IdMensaje", typeof(int));
            DataColumn Idioma = new DataColumn("Idioma", typeof(string));
            DataColumn Nombre = new DataColumn("Nombre", typeof(string));
            DataColumn Texto = new DataColumn("Texto", typeof(string));
            mMensajes.Columns.Add(IdMensaje);
            mMensajes.Columns.Add(Idioma);
            mMensajes.Columns.Add(Nombre);
            mMensajes.Columns.Add(Texto);

            foreach (Mensaje mMensaje in (new MensajeBL()).Listar())
            {
                mMensajes.Rows.Add(mMensaje.IdMensaje, mMensaje.Idioma, mMensaje.Nombre, mMensaje.Texto);
            }

            return mMensajes;
        }
    }
}
