namespace FirmaXML
{
    partial class FrmRegistro
    {
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

        private void InitializeComponent()
        {
            this.lblModel = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.lblMAC = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnLicencia = new System.Windows.Forms.Button();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(13, 36);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(42, 13);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Modelo";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(13, 67);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(28, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Tipo";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Location = new System.Drawing.Point(13, 98);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(27, 13);
            this.lblSerialNumber.TabIndex = 2;
            this.lblSerialNumber.Text = "S/N";
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Location = new System.Drawing.Point(13, 128);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(30, 13);
            this.lblMAC.TabIndex = 3;
            this.lblMAC.Text = "MAC";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(84, 33);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(194, 20);
            this.txtModel.TabIndex = 4;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(84, 64);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(194, 20);
            this.txtType.TabIndex = 5;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(84, 95);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(194, 20);
            this.txtSerialNumber.TabIndex = 6;
            // 
            // txtMAC
            // 
            this.txtMAC.Location = new System.Drawing.Point(84, 125);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(194, 20);
            this.txtMAC.TabIndex = 7;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(108, 266);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(75, 39);
            this.btnUsuario.TabIndex = 8;
            this.btnUsuario.Text = "Obtener Data";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnLicencia
            // 
            this.btnLicencia.Location = new System.Drawing.Point(203, 266);
            this.btnLicencia.Name = "btnLicencia";
            this.btnLicencia.Size = new System.Drawing.Size(75, 39);
            this.btnLicencia.TabIndex = 9;
            this.btnLicencia.Text = "Verificar Licencia";
            this.btnLicencia.UseVisualStyleBackColor = true;
            this.btnLicencia.Click += new System.EventHandler(this.btnLicencia_Click);
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(84, 160);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(194, 20);
            this.txtDeviceName.TabIndex = 11;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(84, 195);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(194, 20);
            this.txtUser.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(84, 230);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 20);
            this.textBox3.TabIndex = 13;
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(12, 163);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(40, 13);
            this.lblDeviceName.TabIndex = 14;
            this.lblDeviceName.Text = "Equipo";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(13, 198);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 15;
            this.lblUser.Text = "Usuario";
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(13, 233);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(53, 13);
            this.lblSerial.TabIndex = 16;
            this.lblSerial.Text = "Licencia?";
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 342);
            this.Controls.Add(this.lblSerial);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblDeviceName);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtDeviceName);
            this.Controls.Add(this.btnLicencia);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.txtMAC);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblMAC);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblModel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRegistro";
            this.Text = "FIRMA XML - Registro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRegistro_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.Label lblMAC;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnLicencia;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSerial;
    }
}