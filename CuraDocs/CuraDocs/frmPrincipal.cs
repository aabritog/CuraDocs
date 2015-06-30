﻿using System;
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
    public partial class frmPrincipal : Form
    {
        CuraduriaEntities1 datacontext = new CuraduriaEntities1();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void digitalizaciónDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDigitalizacion form = new frmDigitalizacion();
            form.ShowDialog();
        }

        private void consultaDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta form = new frmConsulta();
            form.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmUsuarios form = new frmAdmUsuarios();
            form.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CrearMenu();
            lblUsuario.Text = clsGlobal.usuarioGlobal;
            lblAdministrador.Text = clsGlobal.rolGlobal;
            lblFecha.Text = DateTime.Now.ToString();
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void CrearMenu()
        {
            string menuName= string.Empty;
            List<spGetMenuPerfil_Result> listaMenu = new List<spGetMenuPerfil_Result>();
            listaMenu = datacontext.spGetMenuPerfil(clsGlobal.usuarioGlobal).ToList();

            foreach (ToolStripItem item in menu.Items)
            {
                foreach (spGetMenuPerfil_Result itemMenu in listaMenu)
                {
                    if (item.Name == itemMenu.Menu)
                    {
                        menuName = itemMenu.Menu;
                        break;
                    }
                    
                }

                if (!string.IsNullOrEmpty(menuName))
                {
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
                menuName = string.Empty;
            }
        }

        private void activarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.notificaciones = true;
            MessageBox.Show("Envio de Notificaciones se ha Activado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void desactivarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.notificaciones = false;
            MessageBox.Show("Envio de Notificaciones se ha Desactivado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotificacionUsuario form = new frmNotificacionUsuario();
            form.ShowDialog();
        }
    }
}
