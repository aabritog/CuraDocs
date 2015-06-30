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
    
    public partial class frmDigitalizacion : Form
    {
        public bool cargo = false;
        CuraduriaEntities1 datacontext = new CuraduriaEntities1();
        public frmDigitalizacion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado = Convert.ToInt32(datacontext.spBuscarSolicitud(Convert.ToInt32(txtNroRadicacion.Text)).ToList()[0].RESULTADO);

            if (resultado == 1)
            {
                txtNroRadicacion.ReadOnly = true;
                btnExaminar.Enabled = true;
                btnGuardar.Enabled = true;
                panel1.Visible = true;
                btnTerminar.Visible = true;
                button1.Enabled = false;
                //dgvTipoDocumentos.Visible = true;
                //groupBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("El número de Radicación ingresado no se encuentra en la base", "Error");

            }
        }

        private void frmDigitalizacion_Load(object sender, EventArgs e)
        {
            txtNroRadicacion.Focus();

            List<spBuscarTipoDocumento_Result> lista=new List<spBuscarTipoDocumento_Result>();
            lista=datacontext.spBuscarTipoDocumento().ToList();
            dgvTipoDocumentos.Rows.Clear();
            foreach (spBuscarTipoDocumento_Result item in lista)
            {
                dgvTipoDocumentos.Rows.Add(item.id.ToString(), item.documento.ToString(),0);
                dgvTipoDocumentos.Columns[2].ReadOnly = false;
            }

            lblFecha.Text = DateTime.Now.ToString();
            timer1.Start();
            lblAdministrador.Text = clsGlobal.rolGlobal;
            lblUsuario.Text = clsGlobal.usuarioGlobal;

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.FileName = string.Empty;
                this.openFileDialog1.ShowDialog();
                if (string.IsNullOrEmpty(this.openFileDialog1.FileName) == false)
                {
                    
                        txtExaminar.Text = this.openFileDialog1.FileName;
                        groupBox1.Visible = true;
                                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            bool cont = false;
            if (!string.IsNullOrEmpty(txtExaminar.Text))
            {
                foreach (DataGridViewRow row in dgvTipoDocumentos.Rows)
                {
                    if (row.Cells[2].Value.ToString() == "1")
                    {

                        string rutaOrigen = txtExaminar.Text;
                        string nombreDocumento = row.Cells[1].Value.ToString();
                        string rutaDestino = Directory.GetCurrentDirectory() + @"\" + "ImagenesSolicitud" + @"\" + txtNroRadicacion.Text + @"\" + nombreDocumento;
                        string nombreArchivo = DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString() + DateTime.Now.TimeOfDay.ToString().Replace(":","") + "_" + txtNroRadicacion.Text + Path.GetExtension(txtExaminar.Text);
                        if (!Directory.Exists(rutaDestino))
                        {
                            Directory.CreateDirectory(rutaDestino);
                        }

                        File.Copy(rutaOrigen, rutaDestino + @"\" + nombreArchivo);
                        resultado = datacontext.spInsertarImagenes(Convert.ToInt32(txtNroRadicacion.Text), rutaDestino + @"\" + nombreArchivo, Convert.ToInt32(row.Cells[0].Value), clsGlobal.usuarioGlobal).ToList()[0].resultado;
                        row.Cells[2].ReadOnly = true;
                        row.Visible = false;
                        row.Cells[2].Value = 0;
                        cont = true;
                        cargo = true;
                    }



                }

                if (!cont)
                {
                    MessageBox.Show("Debe Seleccionar un tipo de Documento", "Mensaje");
                }
                else
                {
                    MessageBox.Show("Documento cargado exitosamente", "Mensaje");
                    txtExaminar.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            if (cargo && clsGlobal.notificaciones)
            {
                // aqui se envia correo a profesionales....
            }

            groupBox1.Visible = false;
            btnTerminar.Visible = false;
            btnExaminar.Enabled = false;
            btnGuardar.Enabled = false;
            txtNroRadicacion.ReadOnly = false;
            button1.Enabled = true;
            txtExaminar.Text = string.Empty;
            txtNroRadicacion.Text = string.Empty;
            txtNroRadicacion.Focus();
            foreach (DataGridViewRow row in dgvTipoDocumentos.Rows)
            {
                row.Cells[2].Value = 0;
                row.Cells[2].ReadOnly = false;
                row.Visible = true;
            }
            dgvTipoDocumentos.Rows[0].Cells[1].Selected=true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
