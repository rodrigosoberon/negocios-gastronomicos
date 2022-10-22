using BE;
using BL;
using System;
using System.Data;
using System.Windows.Forms;

namespace NegociosGastronomicos
{
    public partial class GestionUsuarios : Form
    {
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        public Usuario usuarioSeleccionado = new Usuario();

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            grdUsuarios.Columns.Add("IdUsuario", "IdUsuario");
            grdUsuarios.Columns.Add("Usuario", "Usuario");
            grdUsuarios.Columns.Add("Nombre", "Nombre");
            grdUsuarios.Columns.Add("Apellido", "Apellido");
            grdUsuarios.Columns.Add("Email", "Email");
            grdUsuarios.Columns.Add("Idioma", "Idioma");
            grdUsuarios.Columns.Add("Estado", "Estado");
            grdUsuarios.RowHeadersVisible = false;
            grdUsuarios.AllowUserToAddRows = false;
            grdUsuarios.AllowUserToDeleteRows = false;
            grdUsuarios.MultiSelect = false;
            grdUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdUsuarios.Columns["IdUsuario"].Visible = false;

            try
            {
                MostrarTextos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falta alguna traducción para el lenguaje elegido");
            }

            ActualizarUsuarios();

        }

        private void ActualizarUsuarios()
        {
            grdUsuarios.Rows.Clear();

            foreach (Usuario mUsuario in (new UsuarioBL()).Listar())
            {
                grdUsuarios.Rows.Add(mUsuario.IdUsuario, mUsuario.NombreUsuario, mUsuario.Nombre, mUsuario.Apellido, mUsuario.Email, mUsuario.Idioma, mUsuario.Estado);
            }
        }

        public void MostrarTextos()
        {
            DataTable mMensajes = (new MensajeBL()).ObtenerTraducciones();

            //Creo un DataView de la tabla de traducciones para poder filtrar por el nombre del control
            DataView mMensajesView = new DataView(mMensajes);
            mMensajesView.Sort = "Nombre";

            //Obtengo el texto traducido para cada control con texto de la interfaz

            //Etiquetas:
            lblGestionUsuarios.Text = mMensajesView[mMensajesView.Find(lblGestionUsuarios.Name)]["Texto"].ToString();
            lblUsuario.Text = mMensajesView[mMensajesView.Find(lblUsuario.Name)]["Texto"].ToString();
            lblNombre.Text = mMensajesView[mMensajesView.Find(lblNombre.Name)]["Texto"].ToString();
            lblApellido.Text = mMensajesView[mMensajesView.Find(lblApellido.Name)]["Texto"].ToString();
            lblEmail.Text = mMensajesView[mMensajesView.Find(lblEmail.Name)]["Texto"].ToString();
            lblContrasenaTemporal.Text = mMensajesView[mMensajesView.Find(lblContrasenaTemporal.Name)]["Texto"].ToString();

            //Botones
            btnAgregar.Text = mMensajesView[mMensajesView.Find(btnAgregar.Name)]["Texto"].ToString();
            btnModificar.Text = mMensajesView[mMensajesView.Find(btnModificar.Name)]["Texto"].ToString();
            btnBaja.Text = mMensajesView[mMensajesView.Find(btnBaja.Name)]["Texto"].ToString();
            btnCancelar.Text = mMensajesView[mMensajesView.Find(btnCancelar.Name)]["Texto"].ToString();
            btnLimpiarCampos.Text = mMensajesView[mMensajesView.Find(btnLimpiarCampos.Name)]["Texto"].ToString();

            //Datagrid
            for (int i = 1; i < grdUsuarios.Columns.Count; i++)
            {
                grdUsuarios.Columns[i].HeaderText = mMensajesView[mMensajesView.Find(grdUsuarios.Columns[i].Name)]["Texto"].ToString();
            }
        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombreUsuario.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void grdUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuarioSeleccionado.IdUsuario = Int32.Parse(grdUsuarios.Rows[e.RowIndex].Cells["IdUsuario"].Value.ToString());
            usuarioSeleccionado.NombreUsuario = grdUsuarios.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
            usuarioSeleccionado.Nombre = grdUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            usuarioSeleccionado.Apellido = grdUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            usuarioSeleccionado.Email = grdUsuarios.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            usuarioSeleccionado.Idioma = grdUsuarios.Rows[e.RowIndex].Cells["Idioma"].Value.ToString();
            usuarioSeleccionado.Estado = Boolean.Parse(grdUsuarios.Rows[e.RowIndex].Cells["Estado"].Value.ToString());

            txtNombreUsuario.Text = usuarioSeleccionado.NombreUsuario;
            txtNombre.Text = usuarioSeleccionado.Nombre;
            txtApellido.Text = usuarioSeleccionado.Apellido;
            txtEmail.Text = usuarioSeleccionado.Email;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario {
                NombreUsuario = txtNombreUsuario.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
            };

            UsuarioBL mUBL = new UsuarioBL();
            mUBL.GuardarNuevo(nuevoUsuario);

            txtNombreUsuario.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";

            ActualizarUsuarios();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
