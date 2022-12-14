using BE;
using BL;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace NegociosGastronomicos
{
    public partial class GestionUsuarios : Form
    {
        public static Usuario usuarioLogueado = new Usuario();
        public GestionUsuarios(Usuario usuario)
        {
            this.KeyPreview = true;
            InitializeComponent();
            usuarioLogueado = usuario;
        }

        public static Usuario usuarioSeleccionado = new Usuario();
        public Familia familiaDisponibleSeleccionada = new Familia();
        public Familia familiaAsignadaSeleccionada = new Familia();
        public Patente patenteDisponibleSeleccionada = new Patente();
        public Patente patenteAsignadaSeleccionada = new Patente();

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

            grdFamAsignadas.Columns.Add("IdPatente", "Id");
            grdFamAsignadas.Columns.Add("Descripcion", "Descripcion");
            grdFamAsignadas.RowHeadersVisible = false;
            grdFamAsignadas.AllowUserToAddRows = false;
            grdFamAsignadas.AllowUserToDeleteRows = false;
            grdFamAsignadas.MultiSelect = false;
            grdFamAsignadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdFamDisponibles.Columns.Add("IdPatente", "Id");
            grdFamDisponibles.Columns.Add("Descripcion", "Descripcion");
            grdFamDisponibles.RowHeadersVisible = false;
            grdFamDisponibles.AllowUserToAddRows = false;
            grdFamDisponibles.AllowUserToDeleteRows = false;
            grdFamDisponibles.MultiSelect = false;
            grdFamDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdPatAsignadas.Columns.Add("IdPatente", "Id");
            grdPatAsignadas.Columns.Add("Descripcion", "Descripcion");
            grdPatAsignadas.RowHeadersVisible = false;
            grdPatAsignadas.AllowUserToAddRows = false;
            grdPatAsignadas.AllowUserToDeleteRows = false;
            grdPatAsignadas.MultiSelect = false;
            grdPatAsignadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdPatDisponibles.Columns.Add("IdPatente", "Id");
            grdPatDisponibles.Columns.Add("Descripcion", "Descripcion");
            grdPatDisponibles.RowHeadersVisible = false;
            grdPatDisponibles.AllowUserToAddRows = false;
            grdPatDisponibles.AllowUserToDeleteRows = false;
            grdPatDisponibles.MultiSelect = false;
            grdPatDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                MostrarTextos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falta alguna traducción para el lenguaje elegido" + ex.Message);
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

        private void ActualizarFamiliasAsignadas()
        {
            grdFamAsignadas.Rows.Clear();
            foreach (Usuario mUsuario in new UsuarioBL().Listar())
            {
                if (mUsuario.IdUsuario == usuarioSeleccionado.IdUsuario)
                {
                    foreach (Familia mFamilia in mUsuario.mFamilias)
                    {
                        grdFamAsignadas.Rows.Add(mFamilia.IdFamilia, mFamilia.Descripcion);
                    }
                }
            }
        }

        private void ActualizarFamiliasDisponibles()
        {
            grdFamDisponibles.Rows.Clear();
            foreach (Usuario mUsuario in new UsuarioBL().Listar())
            {
                if (mUsuario.IdUsuario == usuarioSeleccionado.IdUsuario)
                {
                    foreach (Familia disponible in new FamiliaBL().Listar())
                    {
                        bool encontrada = false;
                        foreach (Familia mFamilia in mUsuario.mFamilias)
                        {
                            if (disponible.IdFamilia == mFamilia.IdFamilia)
                            {
                                encontrada = true;
                            }
                        }
                        if (encontrada == false)
                        {
                            grdFamDisponibles.Rows.Add(disponible.IdFamilia, disponible.Descripcion);
                        }
                    }
                }
            }
        }

        private void ActualizarPatentesAsignadas()
        {
            grdPatAsignadas.Rows.Clear();
            foreach (Usuario mUsuario in new UsuarioBL().Listar())
            {
                if (mUsuario.IdUsuario == usuarioSeleccionado.IdUsuario)
                {
                    foreach (Patente mPatente in mUsuario.mPatentes)
                    {
                        grdPatAsignadas.Rows.Add(mPatente.IdPatente, mPatente.Descripcion);
                    }
                }
            }
        }

        private void ActualizarPatentesDisponibles()
        {
            grdPatDisponibles.Rows.Clear();
            foreach (Usuario mUsuario in new UsuarioBL().Listar())
            {
                if (mUsuario.IdUsuario == usuarioSeleccionado.IdUsuario)
                {
                    foreach (Patente disponible in new PatenteBL().Listar())
                    {
                        bool encontrada = false;
                        foreach (Patente mPatente in mUsuario.mPatentes)
                        {
                            if (disponible.IdPatente == mPatente.IdPatente)
                            {
                                encontrada = true;
                            }
                        }
                        if (encontrada == false)
                        {
                            grdPatDisponibles.Rows.Add(disponible.IdPatente, disponible.Descripcion);
                        }
                    }
                }
            }
        }


        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombreUsuario.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
        }

        private void grdUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
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
            ActualizarFamiliasDisponibles();
            ActualizarFamiliasAsignadas();
            ActualizarPatentesAsignadas();
            ActualizarPatentesDisponibles();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string passTemporario = GenerarPassword();

            Usuario nuevoUsuario = new Usuario
            {
                NombreUsuario = txtNombreUsuario.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Email = txtEmail.Text,
                Password = passTemporario,
            };

            try
            {
                UsuarioBL mUBL = new UsuarioBL();
                mUBL.GuardarNuevo(nuevoUsuario);

                //Registro nuevo usuario en bitacora
                Bitacora bitacora = new Bitacora
                {
                    Fecha = DateTime.Now,
                    Usuario = usuarioLogueado.IdUsuario,
                    Descripcion = "Usuario " + nuevoUsuario.NombreUsuario + " creado por administrador",
                    Criticidad = "Medio"
                };
                BitacoraBL mBitacoraBL = new BitacoraBL();
                mBitacoraBL.AgregarBitacora(bitacora);

                txtNombreUsuario.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEmail.Text = "";

                ActualizarUsuarios();


                //Mandar password por correo
                StreamWriter Archivo = new StreamWriter(@"C:\correo\correo.txt");
                Archivo.WriteLine("Enviar correo a: " + nuevoUsuario.Email + " con el password: " + passTemporario);
                Archivo.Close();

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

        private void btnModificar_Click(object sender, EventArgs e)
        {

            usuarioSeleccionado.NombreUsuario = txtNombreUsuario.Text;
            usuarioSeleccionado.Nombre = txtNombre.Text;
            usuarioSeleccionado.Apellido = txtApellido.Text;
            usuarioSeleccionado.Email = txtEmail.Text;
            UsuarioBL mUsuarioBL = new UsuarioBL();
            try
            {
                mUsuarioBL.Modificar(usuarioSeleccionado);

                //Registro nuevo usuario en bitacora
                Bitacora bitacora = new Bitacora
                {
                    Fecha = DateTime.Now,
                    Usuario = usuarioLogueado.IdUsuario,
                    Descripcion = "Usuario " + usuarioSeleccionado.NombreUsuario + " modificado por administrador",
                    Criticidad = "Medio"
                };
                BitacoraBL mBitacoraBL = new BitacoraBL();
                mBitacoraBL.AgregarBitacora(bitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ActualizarUsuarios();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            UsuarioBL mUsuarioBL = new UsuarioBL();
            PatenteBL patenteBL = new PatenteBL();
            usuarioSeleccionado.mPatentes.Clear();

            if (usuarioSeleccionado.Estado == true) //Lógica para deshabilitar usuario
            {
                bool okDeshabilitar = true;
                //Loopeo sus permisos para verificar que esten todos asignadas a al menos un usuario habilitado
                foreach (Patente patente in UsuarioBL.ObtenerPermisos(usuarioSeleccionado))
                {
                    bool asignada = patenteBL.PatenteAsignada(usuarioSeleccionado, patente);
                    if (!asignada)
                    {
                        okDeshabilitar = false;
                    }
                }

                if (okDeshabilitar)
                {
                    //Cambio estado a  deshabilitado
                    usuarioSeleccionado.Estado = false;
                    mUsuarioBL.CambiarEstado(usuarioSeleccionado);

                    //Log en bitacora
                    Bitacora bitacora = new Bitacora
                    {
                        Fecha = DateTime.Now,
                        Usuario = usuarioSeleccionado.IdUsuario,
                        Descripcion = "Usuario " + usuarioSeleccionado.NombreUsuario + " deshabilitado por administrador",
                        Criticidad = "Bajo"
                    };
                    BitacoraBL mBitacoraBL = new BitacoraBL();
                    mBitacoraBL.AgregarBitacora(bitacora);
                }
                else
                {
                    MessageBox.Show("Este usuario no puede deshabilitarse: Posee una o más patentes asignadas solo a él o a usuarios deshabilitados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else //Lógica para habilitar el usuario
            {
                usuarioSeleccionado.Intentos = 0;
                usuarioSeleccionado.Estado = true;
                mUsuarioBL.CambiarEstado(usuarioSeleccionado);
                mUsuarioBL.ActualizarIntentos(usuarioSeleccionado);

                Bitacora bitacora = new Bitacora
                {
                    Fecha = DateTime.Now,
                    Usuario = usuarioSeleccionado.IdUsuario,
                    Descripcion = "Usuario " + usuarioSeleccionado.NombreUsuario + " habilitado por administrador",
                    Criticidad = "Medio"
                };
                BitacoraBL mBitacoraBL = new BitacoraBL();
                mBitacoraBL.AgregarBitacora(bitacora);
            }
            ActualizarUsuarios();
        }

        private void btnFamAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBL mUsuarioBL = new UsuarioBL();
                mUsuarioBL.AsignarFamilia(usuarioSeleccionado, familiaDisponibleSeleccionada);
                ActualizarFamiliasAsignadas();
                ActualizarFamiliasDisponibles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnFamRemover_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBL mUsuarioBL = new UsuarioBL();
                PatenteBL mPatenteBL = new PatenteBL();
                FamiliaBL mFamiliaBL = new FamiliaBL();
                familiaAsignadaSeleccionada.mPatentes.Clear();
                mFamiliaBL.ObtenerAsignados(familiaAsignadaSeleccionada);

                //Validar que no queden patentes de la familia desasignadas
                bool tieneDesasignadas = false;

                //Loopeo todas las patentes de la familia
                foreach (Patente mPatente in familiaAsignadaSeleccionada.mPatentes)
                {
                    //Si la patente esta asociada a otro usuario devuelve true
                    if (!mPatenteBL.PatenteAsignada(usuarioSeleccionado, mPatente))
                    {
                        tieneDesasignadas = true;
                    }
                }

                //Si no hay patentes desasignadas, desasigna la familia
                if (!tieneDesasignadas)
                {
                    mUsuarioBL.RemoverFamilia(usuarioSeleccionado, familiaAsignadaSeleccionada);
                }
                else
                {
                    MessageBox.Show("La familia no puede ser desasignada. Dejaría permisos sin asignar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ActualizarFamiliasAsignadas();
                ActualizarFamiliasDisponibles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnPatAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBL mUsuarioBL = new UsuarioBL();
                mUsuarioBL.AsignarPatente(usuarioSeleccionado, patenteDisponibleSeleccionada);
                ActualizarPatentesAsignadas();
                ActualizarPatentesDisponibles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnPatRemover_Click(object sender, EventArgs e)
        {
            try
            {
                PatenteBL mPatenteBL = new PatenteBL();
                UsuarioBL mUsuarioBL = new UsuarioBL();

                bool asignada = mPatenteBL.PatenteAsignada(patenteAsignadaSeleccionada);
                if (asignada)
                {
                    mUsuarioBL.RemoverPatente(usuarioSeleccionado, patenteAsignadaSeleccionada);
                }
                else
                {
                    MessageBox.Show("La patente no puede quedar desasignada. Asignarla a otro usuario habilitado primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ActualizarPatentesAsignadas();
                ActualizarPatentesDisponibles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void grdFamAsignadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                familiaAsignadaSeleccionada.IdFamilia = Int32.Parse(grdFamAsignadas.Rows[e.RowIndex].Cells[0].Value.ToString());
                familiaAsignadaSeleccionada.Descripcion = grdFamAsignadas.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void grdFamDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                familiaDisponibleSeleccionada.IdFamilia = Int32.Parse(grdFamDisponibles.Rows[e.RowIndex].Cells[0].Value.ToString());
                familiaDisponibleSeleccionada.Descripcion = grdFamDisponibles.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void grdPatAsignadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                patenteAsignadaSeleccionada.IdPatente = Int32.Parse(grdPatAsignadas.Rows[e.RowIndex].Cells[0].Value.ToString());
                patenteAsignadaSeleccionada.Descripcion = grdPatAsignadas.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void grdPatDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                patenteDisponibleSeleccionada.IdPatente = Int32.Parse(grdPatDisponibles.Rows[e.RowIndex].Cells[0].Value.ToString());
                patenteDisponibleSeleccionada.Descripcion = grdPatDisponibles.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        public string GenerarPassword()
        {
            string pass = "";
            //Generate random string of characterspassword
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                char c = (char)random.Next(65, 90);
                pass += c.ToString();
            }
            return pass;
        }


        public void MostrarTextos()
        {
            DataTable mMensajes = (new MensajeBL()).ObtenerTraducciones(usuarioLogueado.Idioma);

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
            lblFamAsignadas.Text = mMensajesView[mMensajesView.Find(lblFamAsignadas.Name)]["Texto"].ToString();
            lblFamDisponibles.Text = mMensajesView[mMensajesView.Find(lblFamDisponibles.Name)]["Texto"].ToString();
            lblPatAsignadas.Text = mMensajesView[mMensajesView.Find(lblPatAsignadas.Name)]["Texto"].ToString();
            lblPatDisponibles.Text = mMensajesView[mMensajesView.Find(lblPatDisponibles.Name)]["Texto"].ToString();

            //Botones
            btnAgregar.Text = mMensajesView[mMensajesView.Find(btnAgregar.Name)]["Texto"].ToString();
            btnModificar.Text = mMensajesView[mMensajesView.Find(btnModificar.Name)]["Texto"].ToString();
            btnEstado.Text = mMensajesView[mMensajesView.Find(btnEstado.Name)]["Texto"].ToString();
            btnCancelar.Text = mMensajesView[mMensajesView.Find(btnCancelar.Name)]["Texto"].ToString();
            btnLimpiarCampos.Text = mMensajesView[mMensajesView.Find(btnLimpiarCampos.Name)]["Texto"].ToString();

            //Datagrid
            for (int i = 1; i < grdUsuarios.Columns.Count; i++)
            {
                grdUsuarios.Columns[i].HeaderText = mMensajesView[mMensajesView.Find(grdUsuarios.Columns[i].Name)]["Texto"].ToString();
            }

        }

        private void GestionUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Ayuda ayuda = new Ayuda();
                ayuda.Show();
            }
        }
    }

}
