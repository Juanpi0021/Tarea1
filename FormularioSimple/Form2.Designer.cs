namespace FormularioSimple
{
    partial class Form2
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Servidor = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.Contrasena = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtBD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(364, 93);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(698, 442);
            this.dataGrid.TabIndex = 0;
            // 
            // Servidor
            // 
            this.Servidor.AutoSize = true;
            this.Servidor.Location = new System.Drawing.Point(31, 100);
            this.Servidor.Name = "Servidor";
            this.Servidor.Size = new System.Drawing.Size(49, 13);
            this.Servidor.TabIndex = 1;
            this.Servidor.Text = "Servidor:";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(34, 151);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(46, 13);
            this.Usuario.TabIndex = 2;
            this.Usuario.Text = "Usuario:";
            // 
            // Contrasena
            // 
            this.Contrasena.AutoSize = true;
            this.Contrasena.Location = new System.Drawing.Point(34, 175);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(64, 13);
            this.Contrasena.TabIndex = 3;
            this.Contrasena.Text = "Contraseña:";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(200, 206);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(146, 34);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "CONECTAR";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(101, 93);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(245, 20);
            this.txtServidor.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(101, 144);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(245, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(101, 168);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(245, 20);
            this.txtContrasena.TabIndex = 7;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // txtBD
            // 
            this.txtBD.Location = new System.Drawing.Point(101, 118);
            this.txtBD.Name = "txtBD";
            this.txtBD.Size = new System.Drawing.Size(245, 20);
            this.txtBD.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "BD:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 578);
            this.Controls.Add(this.txtBD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.Contrasena);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Servidor);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label Servidor;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Contrasena;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtBD;
        private System.Windows.Forms.Label label1;
    }
}