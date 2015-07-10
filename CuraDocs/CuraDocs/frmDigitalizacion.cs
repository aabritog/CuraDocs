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
using System.Net;
using System.Net.Mail;

namespace CuraDocs
{
    
    public partial class frmDigitalizacion : Form
    {
        public bool cargo = false;
        
        public int nNotificacionMail = 0;

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
                List<spGetTipoTramiteBySolicitud_Result> lstTipoTramite = new List<spGetTipoTramiteBySolicitud_Result>();
                lstTipoTramite = datacontext.spGetTipoTramiteBySolicitud(Convert.ToInt32(txtNroRadicacion.Text)).ToList();
                lblIdTipoTramite.Text = lstTipoTramite.FirstOrDefault().IdTipoTramite.ToString();
                lblTipoTramite.Text = lstTipoTramite.FirstOrDefault().TipoTramite.ToString();
                lblEtiquetaTramite.Visible = true;
                lblTipoTramite.Visible = true;
                txtNroRadicacion.ReadOnly = true;
                btnExaminar.Enabled = true;
                btnGuardar.Enabled = true;
                panel1.Visible = true;
                //btnTerminar.Visible = true;
                button1.Enabled = false;
                //dgvTipoDocumentos.Visible = true;
                //groupBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("El número de radicación ingresado no se encuentra en la base de datos.", clsGlobal.sTextoErrorMarcoMessageBox);

            }
        }

        private void frmDigitalizacion_Load(object sender, EventArgs e)
        {
            
            List<spGetOpcSistema_Result> listOpcSistema = new List<spGetOpcSistema_Result>();
            listOpcSistema = datacontext.spGetOpcSistema().ToList();
            nNotificacionMail = Convert.ToInt32(listOpcSistema.FirstOrDefault().nNotificacionMail);


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
                        btnTerminar.Visible = true;
                                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, clsGlobal.sTextoErrorMarcoMessageBox);
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
                    MessageBox.Show("Debe Seleccionar un tipo de Documento", clsGlobal.sTextoInformativoMarcoMessageBox);
                }
                else
                {
                    MessageBox.Show("Documento cargado exitosamente", clsGlobal.sTextoInformativoMarcoMessageBox);
                    txtExaminar.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un documento", clsGlobal.sTextoErrorMarcoMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cargo && nNotificacionMail == 1)
                //if (cargo && clsGlobal.notificaciones)
                {
                    List<spGetOpcSistema_Result> listOpcSistema = new List<spGetOpcSistema_Result>();
                    listOpcSistema = datacontext.spGetOpcSistema().ToList();
//                    nNotificacionMail = Convert.ToInt32(listOpcSistema.FirstOrDefault().nNotificacionMail);



                    List<spGetCorreosNotificacion_Result> lstCorreos = new List<spGetCorreosNotificacion_Result>();
                    lstCorreos = datacontext.spGetCorreosNotificacion(Convert.ToInt32(lblIdTipoTramite.Text)).ToList();
                    foreach (spGetCorreosNotificacion_Result correo in lstCorreos)
                    {
                        MailMessage _correo = new MailMessage();
                        SmtpClient smtp = new SmtpClient();
                        _correo.Priority = MailPriority.Normal;
                        _correo.From = new MailAddress(listOpcSistema.FirstOrDefault().sFromMail.ToString());
                        _correo.IsBodyHtml = false;
                        _correo.To.Add(correo.Correo.ToString());
                        _correo.Subject = listOpcSistema.FirstOrDefault().sSubjectMail.ToString().Replace("txtNroRadicacion", txtNroRadicacion.Text.ToString());

                        if (!string.IsNullOrEmpty(listOpcSistema.FirstOrDefault().sCcMail.ToString()))
                        {
                            _correo.CC.Add(new MailAddress(listOpcSistema.FirstOrDefault().sCcMail.ToString()));
                        }


                        _correo.Body = listOpcSistema.FirstOrDefault().sBodyMail.ToString().Replace("NewLine", System.Environment.NewLine.ToString()); //Se agregan los saltos de linea.
                        _correo.Body = _correo.Body.ToString().Replace("txtNroRadicacion", txtNroRadicacion.Text.ToString()); //Se agrega el número de radicación.
                        smtp.Credentials = new NetworkCredential(listOpcSistema.FirstOrDefault().sUserNameCredentialsMail.ToString(), listOpcSistema.FirstOrDefault().sPasswordCredentialsMail.ToString());
                        //smtp.UseDefaultCredentials = false;
                        smtp.Host = listOpcSistema.FirstOrDefault().sHostMail.ToString();
                        smtp.Port = Convert.ToInt32(listOpcSistema.FirstOrDefault().nPortMail);
                        smtp.EnableSsl = true;
                        smtp.Send(_correo);
                        //Se envia correo a profesionales.
                    }
                    
                    MessageBox.Show("Correo enviado correctamente", clsGlobal.sTextoInformativoMarcoMessageBox);
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
                lblEtiquetaTramite.Visible = false;
                lblTipoTramite.Visible = false;
                foreach (DataGridViewRow row in dgvTipoDocumentos.Rows)
                {
                    row.Cells[2].Value = 0;
                    row.Cells[2].ReadOnly = false;
                    row.Visible = true;
                }
                dgvTipoDocumentos.Rows[0].Cells[1].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, clsGlobal.sTextoErrorMarcoMessageBox, MessageBoxButtons.OK);
            }

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
