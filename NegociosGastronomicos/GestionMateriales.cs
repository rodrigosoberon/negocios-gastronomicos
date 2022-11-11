using BE;
using BL;
using System;
using System.Data;
using System.Windows.Forms;

namespace NegociosGastronomicos
{
    public partial class GestionMateriales : Form
    {
        public static Usuario usuarioLogueado = new Usuario();
        public GestionMateriales(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;
        }

        public Material materialSeleccionado = new Material();

        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {
            int cantidadIngresada;
            if (txtCantidad.Text == "")
            {
                cantidadIngresada = 0;
            }
            else
            {
                cantidadIngresada = Int32.Parse(txtCantidad.Text);
            }

            Material MaterialNuevo = new Material
            {
                Descripcion = txtDescripcion.Text,
                Cantidad = cantidadIngresada,
            };

            MaterialBL mMBL = new MaterialBL();
            mMBL.GuardarNuevo(MaterialNuevo);

            ActualizarMateriales();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


            grdMateriales.Columns.Add("IdMaterial", "Id");
            grdMateriales.Columns.Add("Descripcion", "Descripcion");
            grdMateriales.Columns.Add("Cantidad", "Cantidad");
            grdMateriales.Columns.Add("EnRequisicion", "EnRequisicion");
            grdMateriales.RowHeadersVisible = false;
            grdMateriales.AllowUserToAddRows = false;
            grdMateriales.AllowUserToDeleteRows = false;
            grdMateriales.MultiSelect = false;
            grdMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                MostrarTextos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falta alguna traducción para el lenguaje elegido. " + ex.Message);
            }

            ActualizarMateriales();
        }

        public void ActualizarMateriales()
        {
            grdMateriales.Rows.Clear();

            foreach (Material mMaterial in (new MaterialBL()).Listar())
            {
                grdMateriales.Rows.Add(mMaterial.IdMaterial, mMaterial.Descripcion, mMaterial.Cantidad, mMaterial.EnRequisicion);
            }
        }

        private void grdMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                materialSeleccionado.IdMaterial = Int32.Parse(grdMateriales.Rows[e.RowIndex].Cells[0].Value.ToString());
                materialSeleccionado.Descripcion = grdMateriales.Rows[e.RowIndex].Cells[1].Value.ToString();
                materialSeleccionado.Cantidad = Int32.Parse(grdMateriales.Rows[e.RowIndex].Cells[2].Value.ToString());
                materialSeleccionado.EnRequisicion = Boolean.Parse(grdMateriales.Rows[e.RowIndex].Cells[3].Value.ToString());

                txtDescripcion.Text = materialSeleccionado.Descripcion;
                txtCantidad.Text = materialSeleccionado.Cantidad.ToString();
            }
        }

        private void btnModificarMaterial_Click(object sender, EventArgs e)
        {
            materialSeleccionado.Descripcion = txtDescripcion.Text;
            materialSeleccionado.Cantidad = Int32.Parse(txtCantidad.Text);

            MaterialBL materialBL = new MaterialBL();
            materialBL.Modificar(materialSeleccionado);
            ActualizarMateriales();

        }

        private void btnBajaMaterial_Click(object sender, EventArgs e)
        {
            Material materialBorrar = new Material { IdMaterial = materialSeleccionado.IdMaterial };
            MaterialBL materialBL = new MaterialBL();
            materialBL.Borrar(materialBorrar);
            ActualizarMateriales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
            txtDescripcion.Text = "";
        }

        public void MostrarTextos()
        {
            DataTable mMensajes = (new MensajeBL()).ObtenerTraducciones(usuarioLogueado.Idioma);

            //Creo un DataView de la tabla de traducciones para poder filtrar por el nombre del control
            DataView mMensajesView = new DataView(mMensajes);
            mMensajesView.Sort = "Nombre";

            //Obtengo el texto traducido para cada control con texto de la interfaz

            //Etiquetas
            lblGestionMateriales.Text = mMensajesView[mMensajesView.Find(lblGestionMateriales.Name)]["Texto"].ToString();
            lblDesccripcion.Text = mMensajesView[mMensajesView.Find(lblDesccripcion.Name)]["Texto"].ToString();
            lblCantidad.Text = mMensajesView[mMensajesView.Find(lblCantidad.Name)]["Texto"].ToString();

            //Botones
            btnAgregar.Text = mMensajesView[mMensajesView.Find(btnAgregar.Name)]["Texto"].ToString();
            btnModificar.Text = mMensajesView[mMensajesView.Find(btnModificar.Name)]["Texto"].ToString();
            btnBaja.Text = mMensajesView[mMensajesView.Find(btnBaja.Name)]["Texto"].ToString();
            btnCancelar.Text = mMensajesView[mMensajesView.Find(btnCancelar.Name)]["Texto"].ToString();
            btnLimpiarCampos.Text = mMensajesView[mMensajesView.Find(btnLimpiarCampos.Name)]["Texto"].ToString();

            //Datagrid
            for (int i = 1; i < grdMateriales.Columns.Count; i++)
            {
                grdMateriales.Columns[i].HeaderText = mMensajesView[mMensajesView.Find(grdMateriales.Columns[i].Name)]["Texto"].ToString();
            }

            //Helpers
            helpProvider.SetHelpString(txtDescripcion, mMensajesView[mMensajesView.Find("hpDescripcionProducto")]["Texto"].ToString());
            helpProvider.SetHelpString(txtCantidad, mMensajesView[mMensajesView.Find("hpCantidadProducto")]["Texto"].ToString());

            //ToolTips
            toolTip.SetToolTip(btnAgregar, mMensajesView[mMensajesView.Find("ttAgregarProducto")]["Texto"].ToString());
            toolTip.SetToolTip(btnModificar, mMensajesView[mMensajesView.Find("ttModificarProducto")]["Texto"].ToString());
            toolTip.SetToolTip(btnBaja, mMensajesView[mMensajesView.Find("ttEliminarProducto")]["Texto"].ToString());
            toolTip.SetToolTip(btnCancelar, mMensajesView[mMensajesView.Find("ttCancelar")]["Texto"].ToString());
            toolTip.SetToolTip(btnLimpiarCampos, mMensajesView[mMensajesView.Find("ttLimpiar")]["Texto"].ToString());
        }

    }
}
