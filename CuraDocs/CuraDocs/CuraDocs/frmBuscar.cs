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
    public partial class frmBuscar : Form
    {
        BindingSource bs = new BindingSource();
        CuraduriaEntities1 datacontext = new CuraduriaEntities1();
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            try
            {
                switch (clsGlobal.frmtext.ToString())
                {
                    case "frmAdmUsuarios":
                        bs.DataSource = datacontext.spBuscarUsuarios().ToList();
                        dgvBuscar.DataSource = bs.DataSource;
                        dgvBuscar.Columns[4].Visible = false;
                        dgvBuscar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvBuscar.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void dgvBuscar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                switch (clsGlobal.frmtext.ToString())
                {
                    case "frmAdmUsuarios":
                        clsGlobal.perfilUsuario = dgvBuscar.CurrentRow.Cells[2].Value.ToString();
                        clsGlobal.admNombreCompleto = dgvBuscar.CurrentRow.Cells[1].Value.ToString();
                        clsGlobal.admUsuario = dgvBuscar.CurrentRow.Cells[0].Value.ToString();
                        clsGlobal.idPerfil = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[4].Value.ToString());
                        clsGlobal.admTermino = true;
                        break;
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<spBuscarUsuarios_Result> listaUsuarios = datacontext.spBuscarUsuarios().ToList();

                
               
                switch (clsGlobal.frmtext)
                {
                    case "frmAdmUsuarios":
                        var filtro = from spBuscarUsuarios_Result usuario in listaUsuarios where usuario.Usuario.ToUpper().Contains(txtBuscar.Text.ToUpper()) select usuario;
                        dgvBuscar.DataSource = filtro.ToList<spBuscarUsuarios_Result>();
                        break;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    }
}
