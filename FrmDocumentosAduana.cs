using FirmaXML.Business;
using FirmaXML.Business.Implementation;
using FirmaXML.Business.Implementation.Aduana;
using FirmaXML.Entities.Aduana;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaXML
{
    public partial class FrmDocumentosAduana : Form
    {
        private readonly IDocumentoAduanaBusiness _documentoAduanaBusiness;
        public FrmDocumentosAduana()
        {
            _documentoAduanaBusiness = new DocumentoAduanaBusiness();
            InitializeComponent();
            getListofCertificate();
        }

        private void FrmDocumentosAduana_Load(object sender, EventArgs e)
        {
            InicializaCampos();
        }

        private void InicializaCampos()
        {
            if (string.IsNullOrWhiteSpace(selectedFile1.Text))
            {
                btnXML2.Enabled = false;
                btnGeneraDocumento.Enabled = false;
            }
            else
            {
                // Don't forget to re-enable the button
                btnXML2.Enabled = true;
                btnGeneraDocumento.Enabled = true;
            }
            cmbTipoDocumentoAduana.DataSource = FirmaDocumento();
            cmbTipoDocumentoAduana.DisplayMember = "Nombre";
            cmbTipoDocumentoAduana.ValueMember = "Codigo";
            selectedFile1.ReadOnly = true;
            selectedFile2.ReadOnly = true;
        }

        private List<TipoDocumentoAduana> FirmaDocumento()
        {
            var tipoDocumentos = new List<TipoDocumentoAduana>()
            {
                new TipoDocumentoAduana { Codigo = "Documento101", Nombre = "Declaración de Ingreso"},
                new TipoDocumentoAduana { Codigo = "Documento403", Nombre = "Anulación"}
            };
            return tipoDocumentos;
        }

        public List<string> getListofCertificate()
        {
            var certificates = new List<string>();
            X509Store store = new X509Store(StoreLocation.CurrentUser);
            try
            {
                store.Open(OpenFlags.ReadOnly);

                // Place all certificates in an X509Certificate2Collection object.
                X509Certificate2Collection certCollection = store.Certificates;
                foreach (X509Certificate2 x509 in certCollection)
                {
                    dataGridView1.Columns[0].Width = 250;
                    dataGridView1.Columns[1].Width = 5;
                    dataGridView1.Rows.Add(x509.Issuer, x509.Thumbprint);
                    dataGridView1.ClearSelection();
                }
            }
            finally
            {
                store.Close();
            }
            return certificates;
        }

        private void btnXML1_Click(object sender, EventArgs e)
        {
            OpenFileDialog v1 = new OpenFileDialog();
            v1.Filter = "Archivos XML (*.xml)|*.xml";
            DialogResult result = v1.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                String xml1 = Path.GetFileName(v1.FileName);         
                selectedFile1.Text = xml1.Substring(0, xml1.Length - 4);
                btnXML2.Enabled = true;
                btnGeneraDocumento.Enabled = true;
                lblubi1.Text = v1.FileName;
            }
        }

        private void btnXML2_Click(object sender, EventArgs e)
        {
            OpenFileDialog v2 = new OpenFileDialog();
            v2.Filter = "Archivos XML (*.xml)|*.xml";
            DialogResult result = v2.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                String xml2 = Path.GetFileName(v2.FileName);
                selectedFile2.Text = xml2.Substring(0, xml2.Length - 4);
                lblubi2.Text = v2.FileName;
            }
        }        
        private void btnGeneraDocumento_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Certificado"].Value.ToString() ==
                    "E=e-sign@esign-la.com, CN=E-Sign Class 3 Firma Electronica Avanzada CA, OU=Terms of use at www.esign-la.com/acuerdoterceros, O=E-Sign S.A., C=CL")
                {                    
                    string cellValue = Convert.ToString(row.Cells["Huella"].Value);
                    lblhuella.Text = cellValue;
                }
            }
            var codigoTipoDocumento = ((TipoDocumentoAduana)cmbTipoDocumentoAduana.SelectedItem).Codigo;
            _documentoAduanaBusiness.Firmar(codigoTipoDocumento, lblubi1.Text, lblubi2.Text, selectedFile1.Text, selectedFile2.Text, lblhuella.Text);
        }

        private void cmbTipoDocumentoAduana_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoDocumentoAduana.Text == "Anulación")   
            {
                btnXML2.Visible = false;                 
                selectedFile2.Visible = false;
                selectedFile1.Text = null;
                selectedFile2.Text = null;
                btnGeneraDocumento.Enabled = false;
            }
            else
            {
                btnXML2.Visible = true;                
                selectedFile2.Visible = true;
                selectedFile1.Text = null;
                btnGeneraDocumento.Enabled = false;
            }
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicializaCampos();
        }
    }
}
