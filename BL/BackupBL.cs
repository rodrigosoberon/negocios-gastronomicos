using BE;
using DAL;
using System;
using System.Collections.Generic;

namespace BL
{
    public class BackupBL
    {
        public List<Backup> Listar()
        {
            return BackupDAL.Listar();
        }
        public int Resguardar(Backup pBackup)
        {
            BackupDAL.GuardarBackup(pBackup); //Guarda datos del backup en la tabla
            return BackupDAL.Resguardar(pBackup); //Guarda archivo de backup en filesystem
        }

        public int Restaurar(Backup pBackup)
        {
            return BackupDAL.Restaurar(pBackup);
        }
    }
}
