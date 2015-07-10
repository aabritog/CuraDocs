namespace CuraDocs
{
    partial class frmConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNroRadicacion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvArchivos = new System.Windows.Forms.DataGridView();
            this.idTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruta = new System.Windows.Forms.DataGridViewLinkColumn();
            this.idDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCargue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCargue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 149);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(274, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta de Documentos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(0, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 39);
            this.panel1.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(644, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 39);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nro Radicación:";
            // 
            // txtNroRadicacion
            // 
            this.txtNroRadicacion.Location = new System.Drawing.Point(404, 210);
            this.txtNroRadicacion.Name = "txtNroRadicacion";
            this.txtNroRadicacion.Size = new System.Drawing.Size(100, 20);
            this.txtNroRadicacion.TabIndex = 1;
            this.txtNroRadicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroRadicacion_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgvArchivos
            // 
            this.dgvArchivos.AllowUserToAddRows = false;
            this.dgvArchivos.AllowUserToDeleteRows = false;
            this.dgvArchivos.BackgroundColor = System.Drawing.Color.White;
            this.dgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoDocumento,
            this.nombreDocumento,
            this.idSolicitud,
            this.ruta,
            this.idDocumento,
            this.fechaCargue,
            this.userCargue});
            this.dgvArchivos.Location = new System.Drawing.Point(12, 316);
            this.dgvArchivos.Name = "dgvArchivos";
            this.dgvArchivos.ReadOnly = true;
            this.dgvArchivos.RowHeadersVisible = false;
            this.dgvArchivos.Size = new System.Drawing.Size(760, 150);
            this.dgvArchivos.TabIndex = 7;
            this.dgvArchivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArchivos_CellContentClick);
            // 
            // idTipoDocumento
            // 
            this.idTipoDocumento.HeaderText = "idTipoDocumento";
            this.idTipoDocumento.Name = "idTipoDocumento";
            this.idTipoDocumento.ReadOnly = true;
            this.idTipoDocumento.Visible = false;
            // 
            // nombreDocumento
            // 
            this.nombreDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDocumento.HeaderText = "Nombre Documento";
            this.nombreDocumento.Name = "nombreDocumento";
            this.nombreDocumento.ReadOnly = true;
            // 
            // idSolicitud
            // 
            this.idSolicitud.HeaderText = "idSolicitud";
            this.idSolicitud.Name = "idSolicitud";
            this.idSolicitud.ReadOnly = true;
            this.idSolicitud.Visible = false;
            // 
            // ruta
            // 
            this.ruta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ruta.HeaderText = "Archivo";
            this.ruta.Name = "ruta";
            this.ruta.ReadOnly = true;
            this.ruta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ruta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // idDocumento
            // 
            this.idDocumento.HeaderText = "idDocumento";
            this.idDocumento.Name = "idDocumento";
            this.idDocumento.ReadOnly = true;
            this.idDocumento.Visible = false;
            // 
            // fechaCargue
            // 
            this.fechaCargue.HeaderText = "Fecha Cargue";
            this.fechaCargue.Name = "fechaCargue";
            this.fechaCargue.ReadOnly = true;
            // 
            // userCargue
            // 
            this.userCargue.HeaderText = "Usuario Cargue";
            this.userCargue.Name = "userCargue";
            this.userCargue.ReadOnly = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(594, 2);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 16);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "FECHA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(526, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "FECHA:";
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrador.ForeColor = System.Drawing.Color.White;
            this.lblAdministrador.Location = new System.Drawing.Point(352, 2);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(134, 16);
            this.lblAdministrador.TabIndex = 3;
            this.lblAdministrador.Text = "ADMINISTRADOR";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblAdministrador);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 541);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 20);
            this.panel2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(306, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "ROL:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(95, 3);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(80, 16);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "USUARIO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "USUARIO:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvArchivos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNroRadicacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuraDocs - Consulta de Documentos";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNroRadicacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgvArchivos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSolicitud;
        private System.Windows.Forms.DataGridViewLinkColumn ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCargue;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCargue;
    }
}