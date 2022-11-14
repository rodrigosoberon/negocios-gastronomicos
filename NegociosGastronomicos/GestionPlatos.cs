using BE;
using BL;
using System;
using System.Data;
using System.Windows.Forms;

namespace NegociosGastronomicos
{
    public partial class GestionPlatos : Form
    {
        public static Usuario usuarioLogueado = new Usuario();
        public GestionPlatos(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
        }

        Plato platoSeleccionado = new Plato();
        Material disponibleSeleccionado = new Material();
        Material incluidoSeleccionado = new Material();

        private void GestionPlatos_Load(object sender, EventArgs e)
        {
            grdPlatos.Columns.Add("IdPlato", "Id");
            grdPlatos.Columns.Add("Descripcion", "Descripcion");
            grdPlatos.Columns.Add("Importe", "Importe");
            grdPlatos.RowHeadersVisible = false;
            grdPlatos.AllowUserToAddRows = false;
            grdPlatos.AllowUserToDeleteRows = false;
            grdPlatos.MultiSelect = false;
            grdPlatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdIncluidos.Columns.Add("IdMaterial", "Id");
            grdIncluidos.Columns.Add("Descripcion", "Descripcion");
            grdIncluidos.RowHeadersVisible = false;
            grdIncluidos.AllowUserToAddRows = false;
            grdIncluidos.AllowUserToDeleteRows = false;
            grdIncluidos.MultiSelect = false;
            grdIncluidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdDisponibles.Columns.Add("IdMaterial", "Id");
            grdDisponibles.Columns.Add("Descripcion", "Descripcion");
            grdDisponibles.RowHeadersVisible = false;
            grdDisponibles.AllowUserToAddRows = false;
            grdDisponibles.AllowUserToDeleteRows = false;
            grdDisponibles.MultiSelect = false;
            grdDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            MostrarTextos();

            ActualizarPlatos();
            ActualizarDisponibles();
            ActualizarIncluidos();
        }

        public void ActualizarPlatos()
        {
            grdPlatos.Rows.Clear();
            foreach (Plato mPlato in new PlatoBL().Listar())
            {
                grdPlatos.Rows.Add(mPlato.IdPlato, mPlato.Descripcion, mPlato.Importe);
            }
        }

        public void ActualizarIncluidos()
        {
            grdIncluidos.Rows.Clear();
            foreach (Plato mPlato in new PlatoBL().Listar())
            {
                if (mPlato.IdPlato == platoSeleccionado.IdPlato)
                {
                    if (mPlato.Materiales != null)
                    {
                        foreach (Material mMaterial in mPlato.Materiales)
                        {
                            grdIncluidos.Rows.Add(mMaterial.IdMaterial, mMaterial.Descripcion);
                        }
                    }

                }
            }
        }

        public void ActualizarDisponibles()
        {
            grdDisponibles.Rows.Clear();
            foreach (Plato mPlato in new PlatoBL().Listar())
            {
                if (mPlato.IdPlato == platoSeleccionado.IdPlato)
                {
                    foreach (Material disponible in new MaterialBL().Listar())
                    {
                        bool encontrado = false;

                        if (mPlato.Materiales != null)
                        {
                            foreach (Material mMaterial in mPlato.Materiales)
                            {
                                if (disponible.IdMaterial == mMaterial.IdMaterial)
                                {
                                    encontrado = true;
                                }
                            }
                        }

                        if (encontrado == false)
                            grdDisponibles.Rows.Add(disponible.IdMaterial, disponible.Descripcion);
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Plato nuevaPlato = new Plato { Descripcion = txtDescripcion.Text, Importe = float.Parse(txtImporte.Text) };

                PlatoBL mPlatoBL = new PlatoBL();
                mPlatoBL.GuardarNuevo(nuevaPlato);
                txtDescripcion.Text = "";
                txtImporte.Text = "";
                ActualizarPlatos();
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
                platoSeleccionado.Descripcion = txtDescripcion.Text;
                platoSeleccionado.Importe = float.Parse(txtImporte.Text);
                PlatoBL mPlatoBL = new PlatoBL();
                mPlatoBL.Modificar(platoSeleccionado);
                ActualizarPlatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                Plato platoBorrar = new Plato { IdPlato = platoSeleccionado.IdPlato };
                PlatoBL platoBL = new PlatoBL();
                platoBL.Borrar(platoBorrar);
                ActualizarPlatos();
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
            txtImporte.Text = "";
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                PlatoBL mPlatoBL = new PlatoBL();
                mPlatoBL.QuitarMaterial(platoSeleccionado, incluidoSeleccionado);
                ActualizarIncluidos();
                ActualizarDisponibles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                PlatoBL mPlatoBL = new PlatoBL();
                mPlatoBL.IncluirMaterial(platoSeleccionado, disponibleSeleccionado);
                ActualizarIncluidos();
                ActualizarDisponibles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grdPlatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                platoSeleccionado.IdPlato = Int32.Parse(grdPlatos.Rows[e.RowIndex].Cells["IdPlato"].Value.ToString());
                platoSeleccionado.Descripcion = grdPlatos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                platoSeleccionado.Importe = float.Parse(grdPlatos.Rows[e.RowIndex].Cells["Importe"].Value.ToString());
                txtDescripcion.Text = platoSeleccionado.Descripcion;
                txtImporte.Text = platoSeleccionado.Importe.ToString();
                
                ActualizarIncluidos();
                ActualizarDisponibles();
            }
        }

        private void grdIncluidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                incluidoSeleccionado.IdMaterial = Int32.Parse(grdIncluidos.Rows[e.RowIndex].Cells["IdMaterial"].Value.ToString());
            }
        }

        private void grdDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                disponibleSeleccionado.IdMaterial = Int32.Parse(grdDisponibles.Rows[e.RowIndex].Cells["IdMaterial"].Value.ToString());
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
            lblGestionPlatos.Text = mMensajesView[mMensajesView.Find(lblGestionPlatos.Name)]["Texto"].ToString();
            lblNombrePlato.Text = mMensajesView[mMensajesView.Find(lblNombrePlato.Name)]["Texto"].ToString();
            lblPlatos.Text = mMensajesView[mMensajesView.Find(lblPlatos.Name)]["Texto"].ToString();
            lblImporte.Text = mMensajesView[mMensajesView.Find(lblImporte.Name)]["Texto"].ToString();
            lblMaterialesIncluidos.Text = mMensajesView[mMensajesView.Find(lblMaterialesIncluidos.Name)]["Texto"].ToString();
            lblMaterialesDisponibles.Text = mMensajesView[mMensajesView.Find(lblMaterialesDisponibles.Name)]["Texto"].ToString();

            //Botones
            btnAgregar.Text = mMensajesView[mMensajesView.Find(btnAgregar.Name)]["Texto"].ToString();
            btnModificar.Text = mMensajesView[mMensajesView.Find(btnModificar.Name)]["Texto"].ToString();
            btnBaja.Text = mMensajesView[mMensajesView.Find(btnBaja.Name)]["Texto"].ToString();
            btnCancelar.Text = mMensajesView[mMensajesView.Find(btnCancelar.Name)]["Texto"].ToString();
            btnLimpiarCampos.Text = mMensajesView[mMensajesView.Find(btnLimpiarCampos.Name)]["Texto"].ToString();
            btnIncluir.Text = mMensajesView[mMensajesView.Find(btnIncluir.Name)]["Texto"].ToString();
            btnQuitar.Text = mMensajesView[mMensajesView.Find(btnQuitar.Name)]["Texto"].ToString();

            //Datagrids
            for (int i = 1; i < grdPlatos.Columns.Count; i++)
            {
                grdPlatos.Columns[i].HeaderText = mMensajesView[mMensajesView.Find(grdPlatos.Columns[i].Name)]["Texto"].ToString();
            }
            for (int i = 1; i < grdIncluidos.Columns.Count; i++)
            {
                grdIncluidos.Columns[i].HeaderText = mMensajesView[mMensajesView.Find(grdIncluidos.Columns[i].Name)]["Texto"].ToString();
            }
            for (int i = 1; i < grdDisponibles.Columns.Count; i++)
            {
                grdDisponibles.Columns[i].HeaderText = mMensajesView[mMensajesView.Find(grdDisponibles.Columns[i].Name)]["Texto"].ToString();
            }

            //Helpers
            helpProvider.SetHelpString(txtDescripcion, mMensajesView[mMensajesView.Find("hpDescripcionPlato")]["Texto"].ToString());
            helpProvider.SetHelpString(txtImporte, mMensajesView[mMensajesView.Find("hpImporte")]["Texto"].ToString());

            //ToolTips
            toolTip.SetToolTip(btnAgregar, mMensajesView[mMensajesView.Find("ttAgregarPlato")]["Texto"].ToString());
            toolTip.SetToolTip(btnModificar, mMensajesView[mMensajesView.Find("ttModificarPlato")]["Texto"].ToString());
            toolTip.SetToolTip(btnBaja, mMensajesView[mMensajesView.Find("ttBajaPlato")]["Texto"].ToString());
            toolTip.SetToolTip(btnCancelar, mMensajesView[mMensajesView.Find("ttCancelar")]["Texto"].ToString());
            toolTip.SetToolTip(btnLimpiarCampos, mMensajesView[mMensajesView.Find("ttLimpiar")]["Texto"].ToString());
            toolTip.SetToolTip(btnIncluir, mMensajesView[mMensajesView.Find("ttIncluirMaterial")]["Texto"].ToString());
            toolTip.SetToolTip(btnQuitar, mMensajesView[mMensajesView.Find("ttQuitarMaterial")]["Texto"].ToString());

        }
    }
}
