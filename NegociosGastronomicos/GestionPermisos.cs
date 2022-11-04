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
        Familia familiaSeleccionada = new Familia();
        Patente patenteSeleccionada = new Patente();
        Patente asignadaSeleccionada = new Patente();
        Patente disponibleSeleccionada = new Patente();

        private void GestionPermisos_Load(object sender, EventArgs e)
        {
            grdFamilias.Columns.Add("IdFamilia", "Id");
            grdFamilias.Columns.Add("Descripcion", "Descripcion");
            grdFamilias.RowHeadersVisible = false;
            grdFamilias.AllowUserToAddRows = false;
            grdFamilias.AllowUserToDeleteRows = false;
            grdFamilias.MultiSelect = false;
            grdFamilias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdAsignadas.Columns.Add("IdPatente", "Id");
            grdAsignadas.Columns.Add("Descripcion", "Descripcion");
            grdAsignadas.RowHeadersVisible = false;
            grdAsignadas.AllowUserToAddRows = false;
            grdAsignadas.AllowUserToDeleteRows = false;
            grdAsignadas.MultiSelect = false;
            grdAsignadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDisponibles.Columns.Add("IdPatente", "Id");
            grdDisponibles.Columns.Add("Descripcion", "Descripcion");
            grdDisponibles.RowHeadersVisible = false;
            grdDisponibles.AllowUserToAddRows = false;
            grdDisponibles.AllowUserToDeleteRows = false;
            grdDisponibles.MultiSelect = false;
            grdDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
                MessageBox.Show("Falta alguna traducción para el lenguaje elegido. " + ex.Message);
            }

            ActualizarPatentes();
            ActualizarFamilias();
        }

        public void ActualizarFamilias()
        {
            grdFamilias.Rows.Clear();
            foreach (Familia mFamilia in new FamiliaBL().Listar())
            {
                grdFamilias.Rows.Add(mFamilia.IdFamilia, mFamilia.Descripcion);
            }
        }

        public void ActualizarPatentes()
        {
            grdPatentes.Rows.Clear();
            foreach (Patente mPatente in (new PatenteBL()).Listar())
            {
                grdPatentes.Rows.Add(mPatente.IdPatente, mPatente.Descripcion);
            }
        }


        public void ActualizarAsignadas()
        {
            grdAsignadas.Rows.Clear();
            foreach (Familia mFamilia in new FamiliaBL().Listar())
            {
                if (mFamilia.IdFamilia == familiaSeleccionada.IdFamilia)
                {
                    foreach (Patente mPatente in mFamilia.mPatentes)
                    {
                        grdAsignadas.Rows.Add(mPatente.IdPatente, mPatente.Descripcion);
                    }
                }
            }
        }


        public void ActualizarDisponibles()
        {
            grdDisponibles.Rows.Clear();
            foreach (Familia mFamilia in new FamiliaBL().Listar())
            {
                if (mFamilia.IdFamilia == familiaSeleccionada.IdFamilia)
                {
                    foreach (Patente disponible in new PatenteBL().Listar())
                    {
                        bool encontrada = false;
                        foreach (Patente mPatente in mFamilia.mPatentes)
                        {
                            if (disponible.IdPatente == mPatente.IdPatente)
                            {
                                encontrada = true;
                            }
                        }
                        if (encontrada == false)
                            grdDisponibles.Rows.Add(disponible.IdPatente, disponible.Descripcion);
                    }
                }
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

        private void btnAgregarF_Click(object sender, EventArgs e)
        {
            Familia nuevaFamilia = new Familia { Descripcion = txtDescripcionF.Text };

            FamiliaBL mFamiliaBL = new FamiliaBL();
            mFamiliaBL.GuardarNuevo(nuevaFamilia);
            txtDescripcionF.Text = "";
            ActualizarFamilias();
        }

        private void btnModificarF_Click(object sender, EventArgs e)
        {
            familiaSeleccionada.Descripcion = txtDescripcionF.Text;

            FamiliaBL mFamiliaBL = new FamiliaBL();
            mFamiliaBL.Modificar(familiaSeleccionada);
            ActualizarFamilias();
        }

        private void btnBajaF_Click(object sender, EventArgs e)
        {
            Familia familiaBorrar = new Familia { IdFamilia = familiaSeleccionada.IdFamilia };
            FamiliaBL familiaBL = new FamiliaBL();
            familiaBL.Borrar(familiaBorrar);
            ActualizarFamilias();
        }

        private void btnCancelarF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarCamposF_Click(object sender, EventArgs e)
        {
            txtDescripcionF.Text = "";
        }

        private void btnAsignarPatente_Click(object sender, EventArgs e)
        {
            FamiliaBL mFamiliaBL = new FamiliaBL();
            mFamiliaBL.AsignarPatente(familiaSeleccionada, disponibleSeleccionada);
            ActualizarAsignadas();
            ActualizarDisponibles();
        }

        private void btnRemoverPatente_Click(object sender, EventArgs e)
        {
            FamiliaBL mFamiliaBL = new FamiliaBL();
            mFamiliaBL.DesasignarPatente(familiaSeleccionada, asignadaSeleccionada);
            ActualizarAsignadas();
            ActualizarDisponibles();
        }

        private void grdFamilias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            familiaSeleccionada.IdFamilia = Int32.Parse(grdFamilias.Rows[e.RowIndex].Cells[0].Value.ToString());
            familiaSeleccionada.Descripcion = grdFamilias.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescripcionF.Text = familiaSeleccionada.Descripcion;
            ActualizarAsignadas();
            ActualizarDisponibles();
        }

        private void grdDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            disponibleSeleccionada.IdPatente = Int32.Parse(grdDisponibles.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void grdAsignadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            asignadaSeleccionada.IdPatente = Int32.Parse(grdAsignadas.Rows[e.RowIndex].Cells[0].Value.ToString());
        }



        public void MostrarTextos()
        {
            DataTable mMensajes = (new MensajeBL()).ObtenerTraducciones();

            //Creo un DataView de la tabla de traducciones para poder filtrar por el nombre del control
            DataView mMensajesView = new DataView(mMensajes);
            mMensajesView.Sort = "Nombre";

            //Obtengo el texto traducido para cada control con texto de la interfaz

            //Etiquetas
            lblGestionPermisos.Text = mMensajesView[mMensajesView.Find(lblGestionPermisos.Name)]["Texto"].ToString();
            tabPatentes.Text = mMensajesView[mMensajesView.Find(tabPatentes.Name)]["Texto"].ToString();
            lblDescripcion.Text = mMensajesView[mMensajesView.Find(lblDescripcion.Name)]["Texto"].ToString();
            lblListadoFamilias.Text = mMensajesView[mMensajesView.Find(lblListadoFamilias.Name)]["Texto"].ToString();
            lblPatentesAsignadas.Text = mMensajesView[mMensajesView.Find(lblPatentesAsignadas.Name)]["Texto"].ToString();
            lblPatentesDisponibles.Text = mMensajesView[mMensajesView.Find(lblPatentesDisponibles.Name)]["Texto"].ToString();
            lblDescripcionF.Text = mMensajesView[mMensajesView.Find(lblDescripcion.Name)]["Texto"].ToString();


            //Botones
            btnAgregar.Text = mMensajesView[mMensajesView.Find(btnAgregar.Name)]["Texto"].ToString();
            btnModificar.Text = mMensajesView[mMensajesView.Find(btnModificar.Name)]["Texto"].ToString();
            btnBaja.Text = mMensajesView[mMensajesView.Find(btnBaja.Name)]["Texto"].ToString();
            btnCancelar.Text = mMensajesView[mMensajesView.Find(btnCancelar.Name)]["Texto"].ToString();
            btnLimpiarCampos.Text = mMensajesView[mMensajesView.Find(btnLimpiarCampos.Name)]["Texto"].ToString();
            btnAgregarF.Text = mMensajesView[mMensajesView.Find(btnAgregar.Name)]["Texto"].ToString();
            btnModificarF.Text = mMensajesView[mMensajesView.Find(btnModificar.Name)]["Texto"].ToString();
            btnBajaF.Text = mMensajesView[mMensajesView.Find(btnBaja.Name)]["Texto"].ToString();
            btnCancelarF.Text = mMensajesView[mMensajesView.Find(btnCancelar.Name)]["Texto"].ToString();
            btnLimpiarCamposF.Text = mMensajesView[mMensajesView.Find(btnLimpiarCampos.Name)]["Texto"].ToString();
            btnAsignarPatente.Text = mMensajesView[mMensajesView.Find(btnAsignarPatente.Name)]["Texto"].ToString();
            btnRemoverPatente.Text = mMensajesView[mMensajesView.Find(btnRemoverPatente.Name)]["Texto"].ToString();
        }


    }
}
