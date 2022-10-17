using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using BE;

namespace NegociosGastronomicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            grdMateriales.Columns.Add("IdMaterial", "IdMaterial");
            grdMateriales.Columns.Add("Descripcion", "Descripcion");
            grdMateriales.Columns.Add("Cantidad", "Cantidad");
            grdMateriales.Columns.Add("EnRequisicion", "EnRequisicion");
            grdMateriales.RowHeadersVisible = false;
            grdMateriales.AllowUserToAddRows = false;
            grdMateriales.AllowUserToDeleteRows = false;
            grdMateriales.MultiSelect = false;
            grdMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //grdMateriales.EditMode = DataGridViewEditMode.EditProgrammatically;

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
            materialSeleccionado.IdMaterial = Int32.Parse(grdMateriales.Rows[e.RowIndex].Cells[0].Value.ToString());
            materialSeleccionado.Descripcion = grdMateriales.Rows[e.RowIndex].Cells[1].Value.ToString();
            materialSeleccionado.Cantidad = Int32.Parse(grdMateriales.Rows[e.RowIndex].Cells[2].Value.ToString());
            materialSeleccionado.EnRequisicion = Boolean.Parse(grdMateriales.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtDescripcion.Text = materialSeleccionado.Descripcion;
            txtCantidad.Text = materialSeleccionado.Cantidad.ToString();

            //ActualizarMateriales();
        }

        private void btnModificarMaterial_Click(object sender, EventArgs e)
        {
            materialSeleccionado.Descripcion = txtDescripcion.Text;
            materialSeleccionado.Cantidad = Int32.Parse(txtCantidad.Text);

            MaterialBL materialBL = new MaterialBL();
            materialBL.Modificar(materialSeleccionado);
            ActualizarMateriales();

        }
    }
}
