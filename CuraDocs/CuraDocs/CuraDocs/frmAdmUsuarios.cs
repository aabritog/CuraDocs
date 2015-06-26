using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;

namespace CuraDocs
{
    public partial class frmAdmUsuarios : Form
    {
        CuraduriaEntities1 datacontext = new CuraduriaEntities1();
        
        public frmAdmUsuarios()
        {
            InitializeComponent();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clsGlobal.frmtext = this.Name;
            frmBuscar form = new frmBuscar();
            form.ShowDialog();
        }

        private void frmAdmUsuarios_Load(object sender, EventArgs e)
        {

            lblUsuario.Text = clsGlobal.usuarioGlobal;
            lblAdministrador.Text = clsGlobal.rolGlobal;
            List<spGetPerfiles_Result> listaPerfiles = new List<spGetPerfiles_Result>();
            listaPerfiles = datacontext.spGetPerfiles().ToList();
            listaPerfiles.Insert(0, new spGetPerfiles_Result() {IdPerfil=0,Perfil="Seleccione..." });
            cbPerfil.DataSource = listaPerfiles;
            cbPerfil.DisplayMember = "Perfil";
            cbPerfil.ValueMember = "IdPerfil";

            btnEditar.Enabled = false;

            lblFecha.Text = DateTime.Now.ToString();
            timer1.Start();
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdmUsuarios_Activated(object sender, EventArgs e)
        {
            if (clsGlobal.admTermino)
            {
                bloquearCampos();
                txtUsuario.Text = clsGlobal.admUsuario;
                txtNombre.Text = clsGlobal.admNombreCompleto;
                cbPerfil.SelectedValue = clsGlobal.idPerfil;
                clsGlobal.admTermino = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool estado;
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtRepetir.Text))
            {
                MessageBox.Show("Debe completar todos los campos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!txtPass.Text.Equals(txtRepetir.Text))
                {
                    MessageBox.Show("Las contraseñas ingresadas no coinciden.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    estado = chkActivo.Checked ? true : false;
                    if (clsGlobal.accion == "guardar")
                    {
                        datacontext.spGuardarUsuario(txtUsuario.Text, txtNombre.Text, Convert.ToInt32(cbPerfil.SelectedValue), txtPass.Text, lblUsuario.Text, estado);
                    }
                    else
                    {
                        datacontext.spEditarUsuarios(txtUsuario.Text, txtNombre.Text, Convert.ToInt32(cbPerfil.SelectedValue), txtPass.Text, lblUsuario.Text, estado);
                    }
                    MessageBox.Show("Usuario Guardado Correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bloquearCampos();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Enabled = true;
            txtUsuario.Text = string.Empty;
            txtNombre.Enabled = true;
            txtNombre.Text = string.Empty;
            txtPass.Enabled = true;
            txtPass.Text = string.Empty;
            txtRepetir.Enabled = true;
            txtRepetir.Text = string.Empty;
            cbPerfil.SelectedIndex = 0;
            cbPerfil.Enabled = true;
            chkActivo.Checked = true;
            chkActivo.Enabled = false;
            btnGuardar.Enabled = true;
            txtUsuario.Focus();
            clsGlobal.accion = "guardar";
        }

        private void bloquearCampos()
        {
            txtNombre.Enabled = false;
            txtUsuario.Enabled = false;
            cbPerfil.Enabled = false;
            txtPass.Enabled = false;
            txtRepetir.Enabled = false;
            btnEditar.Enabled = true;
            chkActivo.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void desbloquearCampos()
        {
            txtNombre.Enabled = true;
            cbPerfil.Enabled = true;
            txtPass.Enabled = true;
            txtRepetir.Enabled = true;
            btnEditar.Enabled = false;
            chkActivo.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            desbloquearCampos();
            clsGlobal.accion = "editar";
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }


    }
}
