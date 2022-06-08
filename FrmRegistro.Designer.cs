namespace FirmaXML
{
    partial class FrmRegistro
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
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblRut = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblserie = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.txtRutEmpresa = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnLicencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(13, 36);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(13, 67);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(30, 13);
            this.lblRut.TabIndex = 1;
            this.lblRut.Text = "RUT";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 98);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail";
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(13, 128);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(31, 13);
            this.lblserie.TabIndex = 3;
            this.lblserie.Text = "Serie";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(84, 33);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(194, 20);
            this.txtNombreEmpresa.TabIndex = 4;
            // 
            // txtRutEmpresa
            // 
            this.txtRutEmpresa.Location = new System.Drawing.Point(84, 64);
            this.txtRutEmpresa.Name = "txtRutEmpresa";
            this.txtRutEmpresa.Size = new System.Drawing.Size(194, 20);
            this.txtRutEmpresa.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(84, 95);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(84, 125);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(194, 20);
            this.txtSerial.TabIndex = 7;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(108, 160);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(75, 39);
            this.btnUsuario.TabIndex = 8;
            this.btnUsuario.Text = "Crear Usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnLicencia
            // 
            this.btnLicencia.Location = new System.Drawing.Point(203, 160);
            this.btnLicencia.Name = "btnLicencia";
            this.btnLicencia.Size = new System.Drawing.Size(75, 39);
            this.btnLicencia.TabIndex = 9;
            this.btnLicencia.Text = "Verificar Licencia";
            this.btnLicencia.UseVisualStyleBackColor = true;
            this.btnLicencia.Click += new System.EventHandler(this.btnLicencia_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 211);
            this.Controls.Add(this.btnLicencia);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRutEmpresa);
            this.Controls.Add(this.txtNombreEmpresa);
            this.Controls.Add(this.lblserie);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblRut);
            this.Controls.Add(this.lblEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRegistro";
            this.Text = "FIRMA XML - Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.TextBox txtRutEmpresa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnLicencia;
    }
}