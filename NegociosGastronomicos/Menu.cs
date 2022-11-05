using BE;
using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegociosGastronomicos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        



        public void MostrarTextos()
        {
            DataTable mMensajes = (new MensajeBL()).ObtenerTraducciones();

            //Creo un DataView de la tabla para poder filtrar por el nombre del control
            DataView mMensajesView = new DataView(mMensajes);
            mMensajesView.Sort = "Nombre";

            //Obtengo el texto traducido para cada control de la interfaz

            //menu Ventas
            ventasToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(ventasToolStripMenuItem.Name)]["Texto"].ToString();
            abrirMesaToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(abrirMesaToolStripMenuItem.Name)]["Texto"].ToString();
            cambiarMesaToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(cambiarMesaToolStripMenuItem.Name)]["Texto"].ToString();
            cerrarMesaToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(cerrarMesaToolStripMenuItem.Name)]["Texto"].ToString();
            generarPedidoToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(generarPedidoToolStripMenuItem.Name)]["Texto"].ToString();
            realizarCobroToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(realizarCobroToolStripMenuItem.Name)]["Texto"].ToString();

            //menu Produccion
            produccionToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(produccionToolStripMenuItem.Name)]["Texto"].ToString();
            prepararPedidoToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(prepararPedidoToolStripMenuItem.Name)]["Texto"].ToString();
            gestionDePlatosToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(gestionDePlatosToolStripMenuItem.Name)]["Texto"].ToString();
            gestionDeMaterialesToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(gestionDeMaterialesToolStripMenuItem.Name)]["Texto"].ToString();

            //menu Compras y Almacenes
            comprasYAlmacenesToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(comprasYAlmacenesToolStripMenuItem.Name)]["Texto"].ToString();
            requisicionManualToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(requisicionManualToolStripMenuItem.Name)]["Texto"].ToString();
            ordenesDeCompraToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(ordenesDeCompraToolStripMenuItem.Name)]["Texto"].ToString();
            recepcionesToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(recepcionesToolStripMenuItem.Name)]["Texto"].ToString();
            pagosToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(pagosToolStripMenuItem.Name)]["Texto"].ToString();

            //Menu Sistema
            sistemaToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(sistemaToolStripMenuItem.Name)]["Texto"].ToString();
            resguardarrecuperarToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(resguardarrecuperarToolStripMenuItem.Name)]["Texto"].ToString();
            gestionDeUsuariosToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(gestionDeUsuariosToolStripMenuItem.Name)]["Texto"].ToString();
            gestionDePermisosToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(gestionDePermisosToolStripMenuItem.Name)]["Texto"].ToString();

            //Menu Usuario
            usuarioToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(usuarioToolStripMenuItem.Name)]["Texto"].ToString();
            cambiarContrasenaToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(cambiarContrasenaToolStripMenuItem.Name)]["Texto"].ToString();
            cambiarIdiomaToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(cambiarIdiomaToolStripMenuItem.Name)]["Texto"].ToString();
            ayudaToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(ayudaToolStripMenuItem.Name)]["Texto"].ToString();
            cerrarSesionToolStripMenuItem.Text = mMensajesView[mMensajesView.Find(cerrarSesionToolStripMenuItem.Name)]["Texto"].ToString();
            
        }


        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarTextos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falta alguna traducción para el lenguaje elegido. " + ex.Message);
            }
        }


        
        // Manejo de panel contenedor
        
        private void abrirMesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenedorPrincipal.Controls.Clear();
            AbrirMesa abrirMesa = new AbrirMesa() { TopLevel = false, Dock = DockStyle.Fill };
            panelContenedorPrincipal.Controls.Add(abrirMesa);
            abrirMesa.Show();

        }

        private void gestiónDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenedorPrincipal.Controls.Clear();
            GestionMateriales gestionMateriales = new GestionMateriales() { TopLevel = false, Dock = DockStyle.Fill };
            panelContenedorPrincipal.Controls.Add(gestionMateriales);
            gestionMateriales.Show();
        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenedorPrincipal.Controls.Clear();
            GestionUsuarios gestionUsuarios = new GestionUsuarios() {TopLevel = false, Dock = DockStyle.Fill };
            panelContenedorPrincipal.Controls.Add(gestionUsuarios);
            gestionUsuarios.Show();
        }

        private void gestionDePermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenedorPrincipal.Controls.Clear();
            GestionPermisos gestionPermisos = new GestionPermisos() { TopLevel = false, Dock = DockStyle.Fill };
            panelContenedorPrincipal.Controls.Add(gestionPermisos);
            gestionPermisos.Show();
        }

        private void resguardarrecuperarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenedorPrincipal.Controls.Clear();
            ResguardarRecuperar resguardarRecuperar = new ResguardarRecuperar() { TopLevel = false, Dock = DockStyle.Fill };
            panelContenedorPrincipal.Controls.Add(resguardarRecuperar);
            resguardarRecuperar.Show();
        }
    }
}
