using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Management;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace FirmaXML
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            string GetMacAddress()
            {
                string macAddresses = string.Empty;

                foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (nic.OperationalStatus == OperationalStatus.Up)
                    {
                        macAddresses += nic.GetPhysicalAddress().ToString();
                        break;
                    }
                }

                return macAddresses;
            }

            ManagementObjectSearcher moSearcher = new
            ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject wmi_HD in moSearcher.Get())
            {
                HardDrive hd = new HardDrive();  // User Defined Class
                hd.Model = wmi_HD["Model"].ToString();  //Model Number
                hd.Type = wmi_HD["InterfaceType"].ToString();  //Interface Type
                hd.SerialNo = wmi_HD["SerialNumber"].ToString(); //Serial Number
                hardDriveDetails.Add(hd);
                txtModel.Text = hd.Model;
                txtType.Text = hd.Type;
                txtSerialNumber.Text = hd.SerialNo;
                txtDeviceName.Text = Environment.MachineName.ToString();
                txtUser.Text = Environment.UserName.ToString();
                txtMAC.Text = GetMacAddress().ToString();

            }


            InitializeComponent();
            this.Load += FrmRegistro_Load;
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            
        }

        ArrayList hardDriveDetails = new ArrayList();

        private string GetMacAddress()
        {
            string macAddresses = string.Empty;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }

            return macAddresses;
        }

        public void tomarDatos()
        {
            ManagementObjectSearcher moSearcher = new
            ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject wmi_HD in moSearcher.Get())
            {
                HardDrive hd = new HardDrive();  // User Defined Class
                hd.Model = wmi_HD["Model"].ToString();  //Model Number
                hd.Type = wmi_HD["InterfaceType"].ToString();  //Interface Type
                hd.SerialNo = wmi_HD["SerialNumber"].ToString(); //Serial Number
                hardDriveDetails.Add(hd);
                txtModel.Text = hd.Model;
                txtType.Text = hd.Type;
                txtSerialNumber.Text = hd.SerialNo;
                txtDeviceName.Text = Environment.MachineName.ToString();
                txtUser.Text = Environment.UserName.ToString();
                txtMAC.Text = GetMacAddress().ToString();

            }
        }

        public static void crearArchivo()
        {

        }

        public static void updateArchivo()
        {

        }

        public static void verificarArchivo()
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            tomarDatos();
            //activation.checkUsuario(txtModel.Text.ToString(), txtType.Text.ToString(), txtSerialNumber.Text.ToString());            
        }

        private void btnLicencia_Click(object sender, EventArgs e)
        {            
            activation.activarFirmador(txtType.Text.ToString(),txtMAC.Text.ToString());
        }

        private void FrmRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
