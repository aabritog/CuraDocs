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
            CBUsuario.DataSource = listaUsuario;
            CBUsuario.DisplayMember = "Usuario";
            CBUsuario.ValueMember = "Usuario";

            bs.DataSource = datacontext.spGetTipoTramite().ToList();
           
            DGVTipoTramite.DataSource = bs.DataSource;
            DGVTipoTramite.Columns[0].Name = "nIdTipoTramite";
            DGVTipoTramite.Columns[1].Name = "sTipoTramite";
            DGVTipoTramite.Columns[2].Name = "nEstado";
            DGVTipoTramite.Columns[0].Visible = true;
            DGVTipoTramite.Columns[1].Visible = true;
            DGVTipoTramite.Columns[2].Visible = false;
            DGVTipoTramite.Columns[0].HeaderText = "Código";
            DGVTipoTramite.Columns[1].HeaderText = "Trámite";
            DGVTipoTramite.Columns[0].Width = 50;
            DGVTipoTramite.Columns[1].Width = 320;
            DGVTipoTramite.ClearSelection();
    
        }

        // LoadTramiteUsuario: Metodo que permite cargar en un DataGridView los tramites asociados a un usuario especifico.
        private void LoadTramiteUsuario() 
        {
            bs2.DataSource = datacontext.spGetUsuarioTipoTramite(CBUsuario.SelectedValue.ToString());

            DGVUsuarioTipoTramite.DataSource = bs2.DataSource;
            DGVUsuarioTipoTramite.Columns[0].Name = "sUsuario";
            DGVUsuarioTipoTramite.Columns[1].Name = "nIdTipoTramite";
            DGVUsuarioTipoTramite.Columns[2].Name = "sTipoTramite";
            DGVUsuarioTipoTramite.Columns[3].Name = "dFecha";
            DGVUsuarioTipoTramite.Columns[4].Name = "nEstado";
            DGVUsuarioTipoTramite.Columns[0].Visible = false;
            DGVUsuarioTipoTramite.Columns[1].Visible = true;
            DGVUsuarioTipoTramite.Columns[2].Visible = true;
            DGVUsuarioTipoTramite.Columns[3].Visible = false;
            DGVUsuarioTipoTramite.Columns[4].Visible = false;
            DGVUsuarioTipoTramite.Columns[1].Width = 50;
            DGVUsuarioTipoTramite.Columns[2].Width = 320;
            DGVUsuarioTipoTramite.Columns[1].HeaderText = "Código";
            DGVUsuarioTipoTramite.Columns[2].HeaderText = "Trámite";
            DGVUsuarioTipoTramite.ClearSelection();

            TBValidarUsuario.Text = CBUsuario.SelectedValue.ToString();

            if (CBUsuario.SelectedValue.ToString().Trim() != "Seleccione...")
            {
                List<spBuscarUsuarios_Result> listaUsuario = new List<spBuscarUsuarios_Result>();
                listaUsuario = datacontext.spBuscarUsuarios(CBUsuario.SelectedValue.ToString()).ToList();
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

            if (CBUsuario.SelectedValue == "Seleccione...")
            {
                DGVTipoTramite.Enabled = false;
                DGVUsuarioTipoTramite.Enabled = false;
                DGVTipoTramite.ClearSelection();
                DGVUsuarioTipoTramite.ClearSelection();
            }
                else
                {
                    DGVTipoTramite.Enabled = true;
                    DGVUsuarioTipoTramite.Enabled = true;
                    DGVTipoTramite.ClearSelection();
                    DGVUsuarioTipoTramite.ClearSelection();
                }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Se inicializan los objetos de la forma
            lblNombreCompleto.Text = "Seleccione usuario";
            lblPerfil.Text = "Seleccione usuario";
            DGVTipoTramite.ClearSelection();
            DGVUsuarioTipoTramite.ClearSelection();
            DGVUsuarioTipoTramite.DataSource = null;
            CBUsuario.SelectedValue = "Seleccione...";
            TBValidarUsuario.Clear();
            TBValidarTipoTramite.Clear();
            BTNAdd.Enabled = false;
            BTNDel.Enabled = false;
            DGVTipoTramite.Enabled = false;
            DGVUsuarioTipoTramite.Enabled = false;
        }

        private void dgvTipoTramite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BTNAdd.Enabled = true;
            BTNDel.Enabled = false;
            DGVUsuarioTipoTramite.ClearSelection();
            TBValidarTipoTramite.Text = DGVTipoTramite.CurrentRow.Cells[0].Value.ToString();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            clsGlobal.nAction = 3;
            if (string.IsNullOrEmpty(TBValidarUsuario.Text))
            {
                MessageBox.Show("Debe seleccionar un usuario.", clsGlobal.sTextoInformativoMarcoMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                if (string.IsNullOrEmpty(TBValidarTipoTramite.Text))
                {
                    MessageBox.Show("Debe seleccionar el trámite a agregar.", clsGlobal.sTextoInformativoMarcoMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    List<spInsDelValUsuarioTipoTramite_Result> listaUsuario = new List<spInsDelValUsuarioTipoTramite_Result>();
                    listaUsuario = datacontext.spInsDelValUsuarioTipoTramite(TBValidarUsuario.Text.ToString(), Convert.ToInt32(TBValidarTipoTramite.Text),clsGlobal.nAction).ToList();
                    
                    if (Convert.ToInt32(listaUsuario.First().nResult) == 1)
                    {
                        DGVTipoTramite.ClearSelection();
                        DGVUsuarioTipoTramite.ClearSelection();
                        BTNAdd.Enabled = false;
                        MessageBox.Show("El usuario ya posee el trámite seleccionado, elija otro.", clsGlobal.sTextoInformativoMarcoMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        clsGlobal.nAction = 1;
                        datacontext.spInsDelValUsuarioTipoTramite(TBValidarUsuario.Text.ToString(), Convert.ToInt32(TBValidarTipoTramite.Text),clsGlobal.nAction);
                        LoadTramiteUsuario();
                        DGVTipoTramite.ClearSelection();
                        DGVUsuarioTipoTramite.ClearSelection();
                        BTNAdd.Enabled = false;
                        MessageBox.Show("Trámite agregado.", clsGlobal.sTextoInformativoMarcoMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }           
            
        }

        private void BTNDel_Click(object sender, EventArgs e)
        {
            clsGlobal.nAction = 2;
            datacontext.spInsDelValUsuarioTipoTramite(TBValidarUsuario.Text.ToString(), Convert.ToInt32(TBValidarTipoTramite.Text), clsGlobal.nAction);
            LoadTramiteUsuario();
            DGVTipoTramite.ClearSelection();
            DGVUsuarioTipoTramite.ClearSelection();
            BTNDel.Enabled = false;
            MessageBox.Show("Trámite eliminado.", clsGlobal.sTextoInformativoMarcoMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvUsuarioTipoTramite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BTNAdd.Enabled = false;
            BTNDel.Enabled = true;
            DGVTipoTramite.ClearSelection();
            TBValidarTipoTramite.Text = DGVUsuarioTipoTramite.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
