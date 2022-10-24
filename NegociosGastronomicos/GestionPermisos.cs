using BE;
using BL;
using System;
using System.Data;
using System.Windows.Forms;

namespace NegociosGastronomicos
{
    public partial class GestionPermisos : Form
    {
        public GestionPermisos()
        {
            InitializeComponent();
        }

        Patente patenteSeleccionada = new Patente();

        private void GestionPermisos_Load(object sender, EventArgs e)
        {
            grdPatentes.Columns.Add("IdPatente", "Id");
            grdPatentes.Columns.Add("Descripcion", "Descripcion");
            grdPatentes.RowHeadersVisible = false;
            grdPatentes.AllowUserToAddRows = false;
            grdPatentes.AllowUserToDeleteRows = false;
            grdPatentes.MultiSelect = false;
            grdPatentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                MostrarTextos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falta alguna traducción para el lenguaje elegido");
            }

            ActualizarPatentes();
        }

        public void ActualizarPatentes()
        {
            grdPatentes.Rows.Clear();
            foreach (Patente mPatente in (new PatenteBL()).Listar())
            {
                grdPatentes.Rows.Add(mPatente.IdPatente, mPatente.Descripcion);
            }
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Patente nuevaPatente = new Patente { Descripcion = txtDescripcion.Text };

            PatenteBL mPatenteBL = new PatenteBL();
            mPatenteBL.GuardarNuevo(nuevaPatente);
            txtDescripcion.Text = "";
            ActualizarPatentes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            patenteSeleccionada.Descripcion = txtDescripcion.Text;

            PatenteBL mPatenteBL = new PatenteBL();
            mPatenteBL.Modificar(patenteSeleccionada);
            ActualizarPatentes();
        }

        private void grdPatentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            patenteSeleccionada.IdPatente = Int32.Parse(grdPatentes.Rows[e.RowIndex].Cells[0].Value.ToString());
            patenteSeleccionada.Descripcion = grdPatentes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescripcion.Text = patenteSeleccionada.Descripcion;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            Patente patenteBorrar = new Patente { IdPatente = patenteSeleccionada.IdPatente };
            PatenteBL patenteBL = new PatenteBL();
            patenteBL.Borrar(patenteBorrar);
            ActualizarPatentes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
        }

        public void MostrarTextos()
        {
            DataTable mMensajes = (new MensajeBL()).ObtenerTraducciones();
            
            //Creo un DataView de la tabla de traducciones para poder filtrar por el nombre del control
            DataView mMensajesView = new DataView(mMensajes);
            mMensajesView.Sort = "Nombre";

            //Obtengo el texto traducido para cada control con texto de la interfaz
            
            //Etiquetas
            tabPatentes.Text = mMensajesView[mMensajesView.Find(tabPatentes.Name)]["Texto"].ToString();
            lblDescripcion.Text = mMensajesView[mMensajesView.Find(lblDescripcion.Name)]["Texto"].ToString();


            //Botones
            btnAgregar.Text = mMensajesView[mMensajesView.Find(btnAgregar.Name)]["Texto"].ToString();
            btnModificar.Text = mMensajesView[mMensajesView.Find(btnModificar.Name)]["Texto"].ToString();
            btnBaja.Text = mMensajesView[mMensajesView.Find(btnBaja.Name)]["Texto"].ToString();
            btnCancelar.Text = mMensajesView[mMensajesView.Find(btnCancelar.Name)]["Texto"].ToString();
            btnLimpiarCampos.Text = mMensajesView[mMensajesView.Find(btnLimpiarCampos.Name)]["Texto"].ToString();

        }
    }
}
