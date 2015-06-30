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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTipoTramite = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvUsuarioTipoTramite = new System.Windows.Forms.DataGridView();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.BTNDel = new System.Windows.Forms.Button();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBValidarUsuario = new System.Windows.Forms.TextBox();
            this.TBValidarTipoTramite = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoTramite)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioTipoTramite)).BeginInit();
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
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(0, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 39);
            this.panel1.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Blue;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(0, 0);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(140, 39);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            // cbUsuario
            // 
            this.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(77, 215);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(212, 21);
            this.cbUsuario.TabIndex = 9;
            this.cbUsuario.SelectionChangeCommitted += new System.EventHandler(this.cbUsuario_SelectionChangeCommitted);
            this.cbUsuario.SelectedValueChanged += new System.EventHandler(this.cbUsuario_SelectedValueChanged);
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
            this.groupBox1.Controls.Add(this.dgvTipoTramite);
            this.groupBox1.Location = new System.Drawing.Point(12, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 202);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tramites en sistema:";
            // 
            // dgvTipoTramite
            // 
            this.dgvTipoTramite.AllowUserToAddRows = false;
            this.dgvTipoTramite.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTipoTramite.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTipoTramite.BackgroundColor = System.Drawing.Color.White;
            this.dgvTipoTramite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTipoTramite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoTramite.Enabled = false;
            this.dgvTipoTramite.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvTipoTramite.Location = new System.Drawing.Point(6, 19);
            this.dgvTipoTramite.MultiSelect = false;
            this.dgvTipoTramite.Name = "dgvTipoTramite";
            this.dgvTipoTramite.ReadOnly = true;
            this.dgvTipoTramite.RowHeadersVisible = false;
            this.dgvTipoTramite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoTramite.Size = new System.Drawing.Size(344, 177);
            this.dgvTipoTramite.TabIndex = 0;
            this.dgvTipoTramite.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoTramite_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUsuarioTipoTramite);
            this.groupBox2.Location = new System.Drawing.Point(416, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 202);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tramites que puede gestionar el usuario:";
            // 
            // dgvUsuarioTipoTramite
            // 
            this.dgvUsuarioTipoTramite.AllowUserToAddRows = false;
            this.dgvUsuarioTipoTramite.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUsuarioTipoTramite.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarioTipoTramite.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarioTipoTramite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuarioTipoTramite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarioTipoTramite.Enabled = false;
            this.dgvUsuarioTipoTramite.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvUsuarioTipoTramite.Location = new System.Drawing.Point(6, 19);
            this.dgvUsuarioTipoTramite.MultiSelect = false;
            this.dgvUsuarioTipoTramite.Name = "dgvUsuarioTipoTramite";
            this.dgvUsuarioTipoTramite.ReadOnly = true;
            this.dgvUsuarioTipoTramite.RowHeadersVisible = false;
            this.dgvUsuarioTipoTramite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarioTipoTramite.Size = new System.Drawing.Size(344, 177);
            this.dgvUsuarioTipoTramite.TabIndex = 0;
            this.dgvUsuarioTipoTramite.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarioTipoTramite_CellClick);
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
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmNotificacionUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNotificacionUsuario";
            this.Load += new System.EventHandler(this.frmNotificacionUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoTramite)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarioTipoTramite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTipoTramite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvUsuarioTipoTramite;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.Button BTNDel;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox TBValidarUsuario;
        private System.Windows.Forms.TextBox TBValidarTipoTramite;

    }
}