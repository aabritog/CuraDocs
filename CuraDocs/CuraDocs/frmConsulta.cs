using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaDatos;
using System.IO;

namespace CuraDocs
{
    public partial class frmConsulta : Form
    {
        CuraduriaEntities1 datacontext = new CuraduriaEntities1();
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = Convert.ToInt32(datacontext.spBuscarSolicitud(Convert.ToInt32(txtNroRadicacion.Text)).ToList()[0].RESULTADO);

            if (resultado == 1)
            {
                txtNroRadicacion.ReadOnly = false;
                List<spBuscarDocumentosBySolicitud_Result> listaDocumentos = new List<spBuscarDocumentosBySolicitud_Result>();
                listaDocumentos = datacontext.spBuscarDocumentosBySolicitud(Convert.ToInt32(txtNroRadicacion.Text)).ToList();
                dgvArchivos.Rows.Clear();
                foreach (spBuscarDocumentosBySolicitud_Result item in listaDocumentos)
                {
                    dgvArchivos.Rows.Add(item.IdTipoDocumento.ToString(), item.Documento.ToString(), item.IdSolicitud.ToString(), item.Ruta.ToString(), item.IdDocumento.ToString(),item.FechaCreacion.ToString(),item.UsuarioCreacion.ToString());
                    dgvArchivos.Visible = true;
                }

                if (dgvArchivos.Rows.Count <= 0)
                {
                    MessageBox.Show("La solicitud no tiene ningun docuemnto cargado.", clsGlobal.sTextoInformativoMarcoMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("El número de Radicación ingresado no se encuentra en la base", clsGlobal.sTextoErrorMarcoMessageBox);

            }
        }

        private void txtNroRadicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void dgvArchivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (Path.GetExtension(dgvArchivos.CurrentRow.Cells[3].Value.ToString()) == ".pdf")
                {
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.StartInfo.FileName = dgvArchivos.CurrentRow.Cells[3].Value.ToString();
                    proc.Start();
                }
                else
                {
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.StartInfo.FileName = dgvArchivos.CurrentRow.Cells[3].Value.ToString();
                    proc.Start();
                }
            }
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            txtNroRadicacion.Focus();
            dgvArchivos.Visible = false;
            lblFecha.Text = DateTime.Now.ToString();
            timer1.Start();
            lblAdministrador.Text = clsGlobal.rolGlobal;
            lblUsuario.Text = clsGlobal.usuarioGlobal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();

        }
    }
}
