namespace CuraDocs
{
    partial class frmNotificacionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotificacionUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.CBUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVTipoTramite = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGVUsuarioTipoTramite = new System.Windows.Forms.DataGridView();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.BTNDel = new System.Windows.Forms.Button();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBValidarUsuario = new System.Windows.Forms.TextBox();
            this.TBValidarTipoTramite = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTipoTramite)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarioTipoTramite)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 149);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTNLimpiar);
            this.panel1.Controls.Add(this.BTNSalir);
            this.panel1.Location = new System.Drawing.Point(0, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 39);
            this.panel1.TabIndex = 4;
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.BackColor = System.Drawing.Color.Blue;
            this.BTNLimpiar.FlatAppearance.BorderSize = 0;
            this.BTNLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLimpiar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLimpiar.ForeColor = System.Drawing.Color.White;
            this.BTNLimpiar.Location = new System.Drawing.Point(0, 0);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(140, 39);
            this.BTNLimpiar.TabIndex = 19;
            this.BTNLimpiar.Text = "Limpiar";
            this.BTNLimpiar.UseVisualStyleBackColor = false;
            this.BTNLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.BackColor = System.Drawing.Color.Red;
            this.BTNSalir.FlatAppearance.BorderSize = 0;
            this.BTNSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSalir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.ForeColor = System.Drawing.Color.White;
            this.BTNSalir.Location = new System.Drawing.Point(644, 0);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(140, 39);
            this.BTNSalir.TabIndex = 0;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = false;
            this.BTNSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // CBUsuario
            // 
            this.CBUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBUsuario.FormattingEnabled = true;
            this.CBUsuario.Location = new System.Drawing.Point(77, 215);
            this.CBUsuario.Name = "CBUsuario";
            this.CBUsuario.Size = new System.Drawing.Size(212, 21);
            this.CBUsuario.TabIndex = 9;
            this.CBUsuario.SelectionChangeCommitted += new System.EventHandler(this.cbUsuario_SelectionChangeCommitted);
            this.CBUsuario.SelectedValueChanged += new System.EventHandler(this.cbUsuario_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(74, 247);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(97, 13);
            this.lblNombreCompleto.TabIndex = 12;
            this.lblNombreCompleto.Text = "Seleccione usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVTipoTramite);
            this.groupBox1.Location = new System.Drawing.Point(12, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 202);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tramites en sistema:";
            // 
            // DGVTipoTramite
            // 
            this.DGVTipoTramite.AllowUserToAddRows = false;
            this.DGVTipoTramite.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVTipoTramite.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVTipoTramite.BackgroundColor = System.Drawing.Color.White;
            this.DGVTipoTramite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVTipoTramite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTipoTramite.Enabled = false;
            this.DGVTipoTramite.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.DGVTipoTramite.Location = new System.Drawing.Point(6, 19);
            this.DGVTipoTramite.MultiSelect = false;
            this.DGVTipoTramite.Name = "DGVTipoTramite";
            this.DGVTipoTramite.ReadOnly = true;
            this.DGVTipoTramite.RowHeadersVisible = false;
            this.DGVTipoTramite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTipoTramite.Size = new System.Drawing.Size(344, 177);
            this.DGVTipoTramite.TabIndex = 0;
            this.DGVTipoTramite.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoTramite_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGVUsuarioTipoTramite);
            this.groupBox2.Location = new System.Drawing.Point(416, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 202);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tramites que puede gestionar el usuario:";
            // 
            // DGVUsuarioTipoTramite
            // 
            this.DGVUsuarioTipoTramite.AllowUserToAddRows = false;
            this.DGVUsuarioTipoTramite.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVUsuarioTipoTramite.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVUsuarioTipoTramite.BackgroundColor = System.Drawing.Color.White;
            this.DGVUsuarioTipoTramite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVUsuarioTipoTramite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuarioTipoTramite.Enabled = false;
            this.DGVUsuarioTipoTramite.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.DGVUsuarioTipoTramite.Location = new System.Drawing.Point(6, 19);
            this.DGVUsuarioTipoTramite.MultiSelect = false;
            this.DGVUsuarioTipoTramite.Name = "DGVUsuarioTipoTramite";
            this.DGVUsuarioTipoTramite.ReadOnly = true;
            this.DGVUsuarioTipoTramite.RowHeadersVisible = false;
            this.DGVUsuarioTipoTramite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVUsuarioTipoTramite.Size = new System.Drawing.Size(344, 177);
            this.DGVUsuarioTipoTramite.TabIndex = 0;
            this.DGVUsuarioTipoTramite.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarioTipoTramite_CellClick);
            // 
            // BTNAdd
            // 
            this.BTNAdd.Enabled = false;
            this.BTNAdd.Location = new System.Drawing.Point(376, 392);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(32, 23);
            this.BTNAdd.TabIndex = 15;
            this.BTNAdd.Text = ">>";
            this.BTNAdd.UseVisualStyleBackColor = true;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // BTNDel
            // 
            this.BTNDel.Enabled = false;
            this.BTNDel.Location = new System.Drawing.Point(376, 421);
            this.BTNDel.Name = "BTNDel";
            this.BTNDel.Size = new System.Drawing.Size(32, 23);
            this.BTNDel.TabIndex = 16;
            this.BTNDel.Text = "<<";
            this.BTNDel.UseVisualStyleBackColor = true;
            this.BTNDel.Click += new System.EventHandler(this.BTNDel_Click);
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(74, 274);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(97, 13);
            this.lblPerfil.TabIndex = 18;
            this.lblPerfil.Text = "Seleccione usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Perfil:";
            // 
            // TBValidarUsuario
            // 
            this.TBValidarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TBValidarUsuario.Enabled = false;
            this.TBValidarUsuario.Location = new System.Drawing.Point(301, 215);
            this.TBValidarUsuario.Name = "TBValidarUsuario";
            this.TBValidarUsuario.Size = new System.Drawing.Size(67, 20);
            this.TBValidarUsuario.TabIndex = 19;
            this.TBValidarUsuario.Visible = false;
            // 
            // TBValidarTipoTramite
            // 
            this.TBValidarTipoTramite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TBValidarTipoTramite.Enabled = false;
            this.TBValidarTipoTramite.Location = new System.Drawing.Point(301, 240);
            this.TBValidarTipoTramite.Name = "TBValidarTipoTramite";
            this.TBValidarTipoTramite.Size = new System.Drawing.Size(67, 20);
            this.TBValidarTipoTramite.TabIndex = 20;
            this.TBValidarTipoTramite.Visible = false;
            // 
            // frmNotificacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.TBValidarTipoTramite);
            this.Controls.Add(this.TBValidarUsuario);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTNDel);
            this.Controls.Add(this.BTNAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNombreCompleto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNotificacionUsuario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuraDocs - Notificaciones a usuarios";
            this.Load += new System.EventHandler(this.frmNotificacionUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTipoTramite)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarioTipoTramite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.ComboBox CBUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVTipoTramite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGVUsuarioTipoTramite;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.Button BTNDel;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.TextBox TBValidarUsuario;
        private System.Windows.Forms.TextBox TBValidarTipoTramite;

    }
}