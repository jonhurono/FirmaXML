using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaXML
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
            this.Load += FrmRegistro_Load;
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            using (IsolatedStorageFile isolatedStorageFile = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null))
            {
                try
                {
                    using (IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream("setting.txt", System.IO.FileMode.Open, isolatedStorageFile))
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(isolatedStorageFileStream))
                        {
                            var activated = activation.isActivated(sr.ReadLine());
                            if (!activated)
                            {

                            }
                            else
                            {
                                Application.Run(new FrmDocumentosAduana());
                            }
                        }
                    }
                }
                catch
                {
                }
            }

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            activation.crearRegistro(txtNombreEmpresa.Text.ToString(), txtRutEmpresa.Text.ToString(), txtEmail.Text.ToString());            
        }


        private void btnLicencia_Click(object sender, EventArgs e)
        {            
            activation.isActivated(txtSerial.Text.ToString());
        }
    }
}
