using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace CuraDocs
{
    public partial class frmNotificacionUsuario : Form
    {
        BindingSource bs = new BindingSource();
        BindingSource bs2 = new BindingSource();
        CuraduriaEntities1 datacontext = new CuraduriaEntities1();

        // LoadUsuariosTiposTramites: Metodo que permite cargar los usuarios y los tipos de tramites existentes en el sistema, en los abjetos ComboBox y DataGridView respectivamente.
        private void LoadUsuariosTiposTramites ()
        {
            List<spBuscarUsuarios_Result> listaUsuario = new List<spBuscarUsuarios_Result>();
            listaUsuario = datacontext.spBuscarUsuarios(null).ToList();
            listaUsuario.Insert(0, new spBuscarUsuarios_Result() { IdPerfil = 0, Usuario = "Seleccione..." });
            cbUsuario.DataSource = listaUsuario;
            cbUsuario.DisplayMember = "Usuario";
            cbUsuario.ValueMember = "Usuario";

            bs.DataSource = datacontext.spGetTipoTramite().ToList();
           
            dgvTipoTramite.DataSource = bs.DataSource;
            dgvTipoTramite.Columns[0].Name = "nIdTipoTramite";
            dgvTipoTramite.Columns[1].Name = "sTipoTramite";
            dgvTipoTramite.Columns[2].Name = "nEstado";
            dgvTipoTramite.Columns[0].Visible = true;
            dgvTipoTramite.Columns[1].Visible = true;
            dgvTipoTramite.Columns[2].Visible = false;
            dgvTipoTramite.Columns[0].HeaderText = "Código";
            dgvTipoTramite.Columns[1].HeaderText = "Trámite";
            dgvTipoTramite.Columns[0].Width = 50;
            dgvTipoTramite.Columns[1].Width = 320;
            dgvTipoTramite.ClearSelection();
    
        }

        // LoadTramiteUsuario: Metodo que permite cargar en un DataGridView los tramites asociados a un usuario especifico.
        private void LoadTramiteUsuario() 
        {
            bs2.DataSource = datacontext.spGetUsuarioTipoTramite(cbUsuario.SelectedValue.ToString());

            dgvUsuarioTipoTramite.DataSource = bs2.DataSource;
            dgvUsuarioTipoTramite.Columns[0].Name = "sUsuario";
            dgvUsuarioTipoTramite.Columns[1].Name = "nIdTipoTramite";
            dgvUsuarioTipoTramite.Columns[2].Name = "sTipoTramite";
            dgvUsuarioTipoTramite.Columns[3].Name = "dFecha";
            dgvUsuarioTipoTramite.Columns[4].Name = "nEstado";
            dgvUsuarioTipoTramite.Columns[0].Visible = false;
            dgvUsuarioTipoTramite.Columns[1].Visible = true;
            dgvUsuarioTipoTramite.Columns[2].Visible = true;
            dgvUsuarioTipoTramite.Columns[3].Visible = false;
            dgvUsuarioTipoTramite.Columns[4].Visible = false;
            dgvUsuarioTipoTramite.Columns[1].Width = 50;
            dgvUsuarioTipoTramite.Columns[2].Width = 320;
            dgvUsuarioTipoTramite.Columns[1].HeaderText = "Código";
            dgvUsuarioTipoTramite.Columns[2].HeaderText = "Trámite";
            dgvUsuarioTipoTramite.ClearSelection();

            TBValidarUsuario.Text = cbUsuario.SelectedValue.ToString();

            if (cbUsuario.SelectedValue.ToString().Trim() != "Seleccione...")
            {
                List<spBuscarUsuarios_Result> listaUsuario = new List<spBuscarUsuarios_Result>();
                listaUsuario = datacontext.spBuscarUsuarios(cbUsuario.SelectedValue.ToString()).ToList();
                lblNombreCompleto.Text = listaUsuario.FirstOrDefault().Nombre_Completo.ToString();
                lblPerfil.Text = listaUsuario.FirstOrDefault().Perfil.ToString();
            }
            else
            {
                lblNombreCompleto.Text = "Seleccione usuario";
                lblPerfil.Text = "Seleccione usuario";
            }
        }

        
        public frmNotificacionUsuario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void frmNotificacionUsuario_Load(object sender, EventArgs e)
        {
            LoadUsuariosTiposTramites();
        }

        private void cbUsuario_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbUsuario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadTramiteUsuario();

            if (cbUsuario.SelectedValue == "Seleccione usuario")
            {
                dgvTipoTramite.Enabled = false;
                dgvUsuarioTipoTramite.Enabled = false;
                dgvTipoTramite.ClearSelection();
                dgvUsuarioTipoTramite.ClearSelection();
            }
                else
                {
                    dgvTipoTramite.Enabled = true;
                    dgvUsuarioTipoTramite.Enabled = true;
                    dgvTipoTramite.ClearSelection();
                    dgvUsuarioTipoTramite.ClearSelection();
                }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblNombreCompleto.Text = "Seleccione usuario";
            lblPerfil.Text = "Seleccione usuario";
            dgvTipoTramite.ClearSelection();
            dgvUsuarioTipoTramite.ClearSelection();
            dgvUsuarioTipoTramite.DataSource = null;
            cbUsuario.SelectedValue = "Seleccione...";
            TBValidarUsuario.Clear();
            TBValidarTipoTramite.Clear();
            BTNAdd.Enabled = false;
            BTNDel.Enabled = false;
            dgvTipoTramite.Enabled = false;
            dgvUsuarioTipoTramite.Enabled = false;
        }

        private void dgvTipoTramite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BTNAdd.Enabled = true;
            BTNDel.Enabled = false;
            dgvUsuarioTipoTramite.ClearSelection();
            TBValidarTipoTramite.Text = dgvTipoTramite.CurrentRow.Cells[0].Value.ToString();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            clsGlobal.nAction = 3;
            if (string.IsNullOrEmpty(TBValidarUsuario.Text))
            {
                MessageBox.Show("Debe seleccionar un usuario.", "CuraDocs - Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                if (string.IsNullOrEmpty(TBValidarTipoTramite.Text))
                {
                    MessageBox.Show("Debe seleccionar el tramite a agregar.", "CuraDocs - Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    List<spInsDelValUsuarioTipoTramite_Result> listaUsuario = new List<spInsDelValUsuarioTipoTramite_Result>();
                    listaUsuario = datacontext.spInsDelValUsuarioTipoTramite(TBValidarUsuario.Text.ToString(), Convert.ToInt32(TBValidarTipoTramite.Text),clsGlobal.nAction).ToList();
                    
                    if (Convert.ToInt32(listaUsuario.First().nResult) == 1)
                    {
                        dgvTipoTramite.ClearSelection();
                        dgvUsuarioTipoTramite.ClearSelection();
                        BTNAdd.Enabled = false;
                        MessageBox.Show("El usuario ya posee el tramite seleccionado, seleccione otro.", "CuraDocs - Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        clsGlobal.nAction = 1;
                        datacontext.spInsDelValUsuarioTipoTramite(TBValidarUsuario.Text.ToString(), Convert.ToInt32(TBValidarTipoTramite.Text),clsGlobal.nAction);
                        LoadTramiteUsuario();
                        dgvTipoTramite.ClearSelection();
                        dgvUsuarioTipoTramite.ClearSelection();
                        BTNAdd.Enabled = false;
                        MessageBox.Show("Tramite agregado.", "CuraDocs - Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }           
            
        }

        private void BTNDel_Click(object sender, EventArgs e)
        {
            clsGlobal.nAction = 2;
            datacontext.spInsDelValUsuarioTipoTramite(TBValidarUsuario.Text.ToString(), Convert.ToInt32(TBValidarTipoTramite.Text), clsGlobal.nAction);
            LoadTramiteUsuario();
            dgvTipoTramite.ClearSelection();
            dgvUsuarioTipoTramite.ClearSelection();
            BTNDel.Enabled = false;
            MessageBox.Show("Tramite eliminado.", "CuraDocs - Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvUsuarioTipoTramite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BTNAdd.Enabled = false;
            BTNDel.Enabled = true;
            dgvTipoTramite.ClearSelection();
            TBValidarTipoTramite.Text = dgvUsuarioTipoTramite.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
