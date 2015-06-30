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
    public partial class Form1 : Form
    {
        CuraduriaEntities1 datacontext = new CuraduriaEntities1();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<spAutenticacionUsuario_Result> listaUsuario = new List<spAutenticacionUsuario_Result>();
            listaUsuario = datacontext.spAutenticacionUsuario(textBox1.Text,textBox2.Text).ToList();

            if (listaUsuario.Count > 0)
            {
                clsGlobal.usuarioGlobal = listaUsuario.FirstOrDefault().Usuario.ToString();
                clsGlobal.rolGlobal = listaUsuario.FirstOrDefault().Perfil.ToString();
                frmPrincipal form = new frmPrincipal();
                form.ShowDialog();
            }
            else
            {
                lblError.Visible = true;
            }
            
            
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "ABRITO";
            textBox2.Text = "root";
        }
    }
}
