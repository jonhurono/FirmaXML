namespace FirmaXML
{
    partial class FrmDocumentosAduana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocumentosAduana));
            this.lblTipoDocumentoAduana = new System.Windows.Forms.Label();
            this.cmbTipoDocumentoAduana = new System.Windows.Forms.ComboBox();
            this.btnGeneraDocumento = new System.Windows.Forms.Button();
            this.grpDadosGenerales = new System.Windows.Forms.GroupBox();
            this.lblubi2 = new System.Windows.Forms.Label();
            this.lblubi1 = new System.Windows.Forms.Label();
            this.selectedFile2 = new System.Windows.Forms.TextBox();
            this.selectedFile1 = new System.Windows.Forms.TextBox();
            this.btnXML2 = new System.Windows.Forms.Button();
            this.btnXML1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Certificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Huella = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblhuella = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDadosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipoDocumentoAduana
            // 
            this.lblTipoDocumentoAduana.AutoSize = true;
            this.lblTipoDocumentoAduana.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTipoDocumentoAduana.Location = new System.Drawing.Point(8, 45);
            this.lblTipoDocumentoAduana.Name = "lblTipoDocumentoAduana";
            this.lblTipoDocumentoAduana.Size = new System.Drawing.Size(155, 20);
            this.lblTipoDocumentoAduana.TabIndex = 57;
            this.lblTipoDocumentoAduana.Text = "  Tipo de Documento";
            // 
            // cmbTipoDocumentoAduana
            // 
            this.cmbTipoDocumentoAduana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumentoAduana.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDocumentoAduana.Location = new System.Drawing.Point(167, 42);
            this.cmbTipoDocumentoAduana.Name = "cmbTipoDocumentoAduana";
            this.cmbTipoDocumentoAduana.Size = new System.Drawing.Size(268, 28);
            this.cmbTipoDocumentoAduana.TabIndex = 58;
            this.cmbTipoDocumentoAduana.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDocumentoAduana_SelectedIndexChanged);
            // 
            // btnGeneraDocumento
            // 
            this.btnGeneraDocumento.Enabled = false;
            this.btnGeneraDocumento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneraDocumento.Location = new System.Drawing.Point(155, 99);
            this.btnGeneraDocumento.Name = "btnGeneraDocumento";
            this.btnGeneraDocumento.Size = new System.Drawing.Size(130, 54);
            this.btnGeneraDocumento.TabIndex = 59;
            this.btnGeneraDocumento.Text = "Firmar Documento";
            this.btnGeneraDocumento.UseVisualStyleBackColor = true;
            this.btnGeneraDocumento.Click += new System.EventHandler(this.btnGeneraDocumento_Click);
            // 
            // grpDadosGenerales
            // 
            this.grpDadosGenerales.Controls.Add(this.lblubi2);
            this.grpDadosGenerales.Controls.Add(this.lblubi1);
            this.grpDadosGenerales.Controls.Add(this.selectedFile2);
            this.grpDadosGenerales.Controls.Add(this.selectedFile1);
            this.grpDadosGenerales.Controls.Add(this.btnXML2);
            this.grpDadosGenerales.Controls.Add(this.btnXML1);
            this.grpDadosGenerales.Controls.Add(this.btnGeneraDocumento);
            this.grpDadosGenerales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDadosGenerales.Location = new System.Drawing.Point(12, 84);
            this.grpDadosGenerales.Name = "grpDadosGenerales";
            this.grpDadosGenerales.Size = new System.Drawing.Size(423, 162);
            this.grpDadosGenerales.TabIndex = 60;
            this.grpDadosGenerales.TabStop = false;
            this.grpDadosGenerales.Text = "Selección de archivos";
            // 
            // lblubi2
            // 
            this.lblubi2.AutoSize = true;
            this.lblubi2.Location = new System.Drawing.Point(281, 16);
            this.lblubi2.Name = "lblubi2";
            this.lblubi2.Size = new System.Drawing.Size(0, 17);
            this.lblubi2.TabIndex = 68;
            this.lblubi2.Visible = false;
            // 
            // lblubi1
            // 
            this.lblubi1.AutoSize = true;
            this.lblubi1.Location = new System.Drawing.Point(136, 16);
            this.lblubi1.Name = "lblubi1";
            this.lblubi1.Size = new System.Drawing.Size(0, 17);
            this.lblubi1.TabIndex = 67;
            this.lblubi1.Visible = false;
            // 
            // selectedFile2
            // 
            this.selectedFile2.Location = new System.Drawing.Point(136, 68);
            this.selectedFile2.Name = "selectedFile2";
            this.selectedFile2.ReadOnly = true;
            this.selectedFile2.Size = new System.Drawing.Size(268, 25);
            this.selectedFile2.TabIndex = 66;
            // 
            // selectedFile1
            // 
            this.selectedFile1.Location = new System.Drawing.Point(136, 29);
            this.selectedFile1.Name = "selectedFile1";
            this.selectedFile1.ReadOnly = true;
            this.selectedFile1.Size = new System.Drawing.Size(268, 25);
            this.selectedFile1.TabIndex = 65;
            // 
            // btnXML2
            // 
            this.btnXML2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXML2.Location = new System.Drawing.Point(19, 62);
            this.btnXML2.Margin = new System.Windows.Forms.Padding(2);
            this.btnXML2.Name = "btnXML2";
            this.btnXML2.Size = new System.Drawing.Size(112, 35);
            this.btnXML2.TabIndex = 64;
            this.btnXML2.Text = "Complemento";
            this.btnXML2.UseVisualStyleBackColor = true;
            this.btnXML2.Click += new System.EventHandler(this.btnXML2_Click);
            // 
            // btnXML1
            // 
            this.btnXML1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXML1.Location = new System.Drawing.Point(19, 23);
            this.btnXML1.Margin = new System.Windows.Forms.Padding(2);
            this.btnXML1.Name = "btnXML1";
            this.btnXML1.Size = new System.Drawing.Size(112, 35);
            this.btnXML1.TabIndex = 61;
            this.btnXML1.Text = "Archivo XML";
            this.btnXML1.UseVisualStyleBackColor = true;
            this.btnXML1.Click += new System.EventHandler(this.btnXML1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Certificado,
            this.Huella});
            this.dataGridView1.Location = new System.Drawing.Point(498, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(204, 141);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.Visible = false;
            // 
            // Certificado
            // 
            this.Certificado.HeaderText = "Certificado";
            this.Certificado.Name = "Certificado";
            this.Certificado.ReadOnly = true;
            // 
            // Huella
            // 
            this.Huella.HeaderText = "Huella";
            this.Huella.Name = "Huella";
            this.Huella.ReadOnly = true;
            // 
            // lblhuella
            // 
            this.lblhuella.AutoSize = true;
            this.lblhuella.Location = new System.Drawing.Point(498, 176);
            this.lblhuella.Name = "lblhuella";
            this.lblhuella.Size = new System.Drawing.Size(35, 13);
            this.lblhuella.TabIndex = 62;
            this.lblhuella.Text = "label1";
            this.lblhuella.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(450, 24);
            this.menuStrip1.TabIndex = 63;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reiniciarToolStripMenuItem,
            this.registrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // FrmDocumentosAduana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(450, 258);
            this.Controls.Add(this.lblhuella);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpDadosGenerales);
            this.Controls.Add(this.cmbTipoDocumentoAduana);
            this.Controls.Add(this.lblTipoDocumentoAduana);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmDocumentosAduana";
            this.Text = "FIRMA XML";
            this.Load += new System.EventHandler(this.FrmDocumentosAduana_Load);
            this.grpDadosGenerales.ResumeLayout(false);
            this.grpDadosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTipoDocumentoAduana;
        private System.Windows.Forms.ComboBox cmbTipoDocumentoAduana;
        private System.Windows.Forms.Button btnGeneraDocumento;
        private System.Windows.Forms.GroupBox grpDadosGenerales;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnXML1;
        private System.Windows.Forms.Button btnXML2;
        private System.Windows.Forms.TextBox selectedFile2;
        private System.Windows.Forms.TextBox selectedFile1;
        private System.Windows.Forms.Label lblubi2;
        private System.Windows.Forms.Label lblubi1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Certificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Huella;
        private System.Windows.Forms.Label lblhuella;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
    }
}