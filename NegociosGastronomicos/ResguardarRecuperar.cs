using BE;
using BL;
using System;
using System.Windows.Forms;

namespace NegociosGastronomicos
{
    public partial class ResguardarRecuperar : Form
    {
        public ResguardarRecuperar()
        {
            InitializeComponent();
        }

        Backup copiaSeleccionada = new Backup();

        private void ResguardarRecuperar_Load(object sender, EventArgs e)
        {
            grdBackups.Columns.Add("IdResguardo", "Id");
            grdBackups.Columns.Add("Creado", "Creado");
            grdBackups.Columns.Add("Usuario", "Usuario");
            grdBackups.Columns.Add("Descripcion", "Descripcion");
            grdBackups.Columns.Add("Particiones", "Particiones");
            grdBackups.Columns.Add("Ubicacion", "Ubicacion");
            grdBackups.RowHeadersVisible = false;
            grdBackups.AllowUserToAddRows = false;
            grdBackups.AllowUserToDeleteRows = false;
            grdBackups.MultiSelect = false;
            grdBackups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ActualizarBackups();
        }

        public void ActualizarBackups()
        {
            grdBackups.Rows.Clear();
            foreach (Backup mBackup in new BackupBL().Listar())
            {
                grdBackups.Rows.Add(mBackup.IdResguardo, mBackup.Creado, mBackup.Usuario.NombreUsuario, mBackup.Descripcion, mBackup.Particiones, mBackup.Ubicacion);
            }
        }

        private void btnResguardar_Click(object sender, EventArgs e)
        {
            try
            {
                Backup mBackup = new Backup
                {
                    Creado = DateTime.Now,
                    Usuario = new Usuario { IdUsuario = 1 }, //TODO: Cambiar por el usuario de la sesion
                    Descripcion = DateTime.Now.ToString().Replace(" ", "-").Replace(":", "-"),
                    Particiones = Int32.Parse(cbPartes.SelectedItem.ToString()),
                    Ubicacion = txtUbicacion.Text
                };
                BackupBL mBackupBL = new BackupBL();
                mBackupBL.Resguardar(mBackup);

                MessageBox.Show("Backup realizado con exito!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }

            ActualizarBackups();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try {
                BackupBL mBackupBL = new BackupBL();
                mBackupBL.Restaurar(copiaSeleccionada);

                MessageBox.Show("Restauracion realizada con exito!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        private void grdBackups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                copiaSeleccionada.IdResguardo = Int32.Parse(grdBackups.Rows[e.RowIndex].Cells[0].Value.ToString());
                copiaSeleccionada.Descripcion = grdBackups.Rows[e.RowIndex].Cells[3].Value.ToString();
                copiaSeleccionada.Particiones = Int32.Parse(grdBackups.Rows[e.RowIndex].Cells[4].Value.ToString());
                copiaSeleccionada.Ubicacion = grdBackups.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
    }
}
