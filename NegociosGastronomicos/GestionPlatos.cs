using BE;
using BL;
using System;
using System.Windows.Forms;

namespace NegociosGastronomicos
{
    public partial class GestionPlatos : Form
    {
        public GestionPlatos()
        {
            InitializeComponent();
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

            //Mostras texts

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
    }
}
