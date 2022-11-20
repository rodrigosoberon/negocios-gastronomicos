using BE;
using BL;
using System;
using System.Data;
using System.Windows.Forms;

namespace NegociosGastronomicos
{
    public partial class GestionPermisos : Form
    {
        public static Usuario usuarioLogueado = new Usuario();
        public GestionPermisos(Usuario usuario)
        {
            this.KeyPreview = true;
            InitializeComponent();
            usuarioLogueado = usuario;
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
            try
            {
                Patente nuevaPatente = new Patente { Descripcion = txtDescripcion.Text };

                PatenteBL mPatenteBL = new PatenteBL();
                mPatenteBL.GuardarNuevo(nuevaPatente);
                txtDescripcion.Text = "";
                ActualizarPatentes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                patenteSeleccionada.Descripcion = txtDescripcion.Text;

                PatenteBL mPatenteBL = new PatenteBL();
                mPatenteBL.Modificar(patenteSeleccionada);
                ActualizarPatentes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void grdPatentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                patenteSeleccionada.IdPatente = Int32.Parse(grdPatentes.Rows[e.RowIndex].Cells[0].Value.ToString());
                patenteSeleccionada.Descripcion = grdPatentes.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcion.Text = patenteSeleccionada.Descripcion;
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                Patente patenteBorrar = new Patente { IdPatente = patenteSeleccionada.IdPatente };
                PatenteBL patenteBL = new PatenteBL();
                patenteBL.Borrar(patenteBorrar);
                ActualizarPatentes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
            try
            {
                Familia nuevaFamilia = new Familia { Descripcion = txtDescripcionF.Text };

                FamiliaBL mFamiliaBL = new FamiliaBL();
                mFamiliaBL.GuardarNuevo(nuevaFamilia);
                txtDescripcionF.Text = "";
                ActualizarFamilias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnModificarF_Click(object sender, EventArgs e)
        {
            try
            {
                familiaSeleccionada.Descripcion = txtDescripcionF.Text;

                FamiliaBL mFamiliaBL = new FamiliaBL();
                mFamiliaBL.Modificar(familiaSeleccionada);
                ActualizarFamilias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBajaF_Click(object sender, EventArgs e)
        {
            try
            {
                Familia familiaBorrar = new Familia { IdFamilia = familiaSeleccionada.IdFamilia };
                PatenteBL mPatenteBL = new PatenteBL();
                FamiliaBL mFamiliaBL = new FamiliaBL();

                //Validar si ok borrar familia
                familiaSeleccionada.mPatentes.Clear();
                mFamiliaBL.ObtenerAsignados(familiaSeleccionada);

                //Validar que no queden patentes de la familia desasignadas
                bool tieneDesasignadas = false;

                //Loopeo todas las patentes de la familia
                foreach (Patente mPatente in familiaSeleccionada.mPatentes)
                {
                    if (!mPatenteBL.PatenteAsignadaDirecta(mPatente))
                    {
                        if (!mFamiliaBL.EnFamiliaAsignada(familiaSeleccionada, mPatente))
                        {
                            tieneDesasignadas = true;
                        }

                    }
                }

                //Si no hay patentes desasignadas, borro la familia
                if (!tieneDesasignadas)
                {
                    mFamiliaBL.Borrar(familiaBorrar);
                }
                else
                {
                    MessageBox.Show("La familia no puede ser borrada. Dejaría permisos sin asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                ActualizarFamilias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
            try
            {
                FamiliaBL mFamiliaBL = new FamiliaBL();
                mFamiliaBL.AsignarPatente(familiaSeleccionada, disponibleSeleccionada);
                ActualizarAsignadas();
                ActualizarDisponibles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRemoverPatente_Click(object sender, EventArgs e)
        {
            try
            {
                FamiliaBL mFamiliaBL = new FamiliaBL();
                PatenteBL mPatenteBL = new PatenteBL();

                //Validar si patente esta asignada direactamente a usuario
                bool asignadaDirecta = mPatenteBL.PatenteAsignadaDirecta(asignadaSeleccionada);
                bool enFamiliaAsignada = mFamiliaBL.EnFamiliaAsignada(familiaSeleccionada, asignadaSeleccionada);

                if (asignadaDirecta || enFamiliaAsignada)
                {
                    mFamiliaBL.DesasignarPatente(familiaSeleccionada, asignadaSeleccionada);
                }
                else
                {
                    MessageBox.Show("La patente no puede ser desasignada. Dejaría un permiso sin asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ActualizarAsignadas();
                ActualizarDisponibles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void grdFamilias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                familiaSeleccionada.IdFamilia = Int32.Parse(grdFamilias.Rows[e.RowIndex].Cells[0].Value.ToString());
                familiaSeleccionada.Descripcion = grdFamilias.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcionF.Text = familiaSeleccionada.Descripcion;
                ActualizarAsignadas();
                ActualizarDisponibles();
            }
        }

        private void grdDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                disponibleSeleccionada.IdPatente = Int32.Parse(grdDisponibles.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void grdAsignadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                asignadaSeleccionada.IdPatente = Int32.Parse(grdAsignadas.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }



        public void MostrarTextos()
        {
            DataTable mMensajes = (new MensajeBL()).ObtenerTraducciones(usuarioLogueado.Idioma);

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

        private void GestionPermisos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Ayuda ayuda = new Ayuda();
                ayuda.Show();
            }
        }
    }
}
