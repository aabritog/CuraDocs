namespace CuraDocs
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBContrasena = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(307, 34);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(106, 20);
            this.TBUsuario.TabIndex = 1;
            this.TBUsuario.Enter += new System.EventHandler(this.TBUsuario_Enter);
            this.TBUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // TBContrasena
            // 
            this.TBContrasena.Location = new System.Drawing.Point(307, 73);
            this.TBContrasena.Name = "TBContrasena";
            this.TBContrasena.Size = new System.Drawing.Size(106, 20);
            this.TBContrasena.TabIndex = 2;
            this.TBContrasena.UseSystemPasswordChar = true;
            this.TBContrasena.Enter += new System.EventHandler(this.TBContrasena_Enter);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(258, 126);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(248, 100);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(168, 13);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Usuario y/o contraseña incorrecto";
            this.lblError.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 163);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.TBContrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBUsuario);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuraDocs - Iniciar Sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBContrasena;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

