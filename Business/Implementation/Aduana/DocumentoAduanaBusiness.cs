using FirmaXML.Entities.Aduana;
using FirmaXML.Repository;
using FirmaXML.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Diagnostics;

namespace FirmaXML.Business.Implementation.Aduana
{
    public class DocumentoAduanaBusiness : IDocumentoAduanaBusiness
    {
        // Constants
        private const string RutaPrincipal = @"C:\XML\";
        private const string DateTimeFormat = "yyyyMMdd";
        private const string PiXmlType = "Rut";
        private const string XMLNS = "http://zofri.cl/sve/doc/ingreso";

        // Privates
        private readonly string _fechaActualtexto;
        private readonly XmlWriterSettings _xmlWriterSettings;
        private readonly IDocumentoAduanaRepository _documentoAduanaRepository;

        public DocumentoAduanaBusiness()
        {
            _documentoAduanaRepository = new DocumentoAduanaRepository();
            _fechaActualtexto = DateTime.Now.ToString(DateTimeFormat);
            _xmlWriterSettings = new XmlWriterSettings
            {
                Indent = true,
                Encoding = new UTF8Encoding(false)
            };
        }

        public void Firmar(string tipoDocumento, string ubiXML1, string ubiXML2, string file1, string file2, string huella)
        {
            if (tipoDocumento == "Documento101")
            {
                DocumentoIngresoYComplemento(ubiXML1, ubiXML2, file1, file2, huella);
            }
            if (tipoDocumento == "Documento201")
            {
                DocumentoSalida(ubiXML1, file1, file2, huella);
            }
            else if (tipoDocumento == "Documento403")
            {
                DocumentoAnulacion(ubiXML1, file1, file2, huella);
            }
        }

        private void DocumentoIngresoYComplemento(string ubiXML1, string ubiXML2, string file1, string file2, string huella)
        {
            var documentos = new List<DocumentoXML>();
            DocumentoXML documento;
            var siglaDocumento = "adu";

            VerificaRutaPrincipal(RutaPrincipal);

            // CONFIGURACIÓN DE SIGNERS
            var signers = new List<SignersXML>();
            SignersXML signer;
            var signersPI = new List<SignerXML>();
            var signerPI = new SignerXML();
            var pisXml = new List<PIXML>();
            var piXml = new PIXML();
            piXml.type = PiXmlType;

            pisXml.Add(piXml);
            signerPI.PI = pisXml;
            signersPI.Add(signerPI);
            signer = new SignersXML();
            signer.Signer_XML = signersPI;
            signers.Add(signer);

            documento = new DocumentoXML();
            documento.ID = "Documento101";

            InsertarFirma(documento.ID.Trim(), ubiXML1, siglaDocumento, file1, file2, huella);

            // DOCUMENTO COMPLEMENTARIO
            var siglaDocumentoComplementario = "compl";
            var documentoComplemento = new DocumentoXMLComplemento { ID_com = "Documento101Compl" };
            InsertarFirma(documentoComplemento.ID_com.Trim(), ubiXML2, siglaDocumentoComplementario, file1, file2, huella);
        }

        private void DocumentoSalida(string ubiXML1, string file1, string file2, string huella)
        {
            var documento = new DocumentoXML { ID = "Documento201" };

            var siglaDocumento = "sve";

            VerificaRutaPrincipal(RutaPrincipal);

            InsertarFirma(documento.ID.Trim(), ubiXML1, siglaDocumento, file1, file2, huella);
        }

        private void DocumentoAnulacion(string ubiXML1, string file1, string file2, string huella)
        {
            var documento = new DocumentoXML { ID = "Documento403" };

            var siglaDocumento = "sve";

            VerificaRutaPrincipal(RutaPrincipal);

            InsertarFirma(documento.ID.Trim(), ubiXML1, siglaDocumento, file1, file2, huella);
        }

        private void VerificaRutaPrincipal(string rutaPrincipal)
        {
            if (!Directory.Exists(rutaPrincipal))
            {
                Directory.CreateDirectory(rutaPrincipal);
            }
        }

        public void InsertarFirma(string tipo, string pathDocument, string tipoDoc, string file1, string file2, string huella)
        {
            // Abre el almacén de certificados de del usuario actual
            X509Store store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);

            X509Certificate2Collection certs = store.Certificates;

            XmlDocument documento = new XmlDocument();
            documento.PreserveWhitespace = true;
            try
            {
                documento.Load(pathDocument);

                SignedXml firmado = new SignedXml(documento);

                X509Certificate2 certificado = null;

                foreach (X509Certificate2 cert in certs)
                {
                    //if (cert.Thumbprint == Properties.Settings.Default.CertThumbPrint)
                    if (cert.Thumbprint == huella)
                    {
                        //var certPass = Encoding.UTF8.GetString(Convert.FromBase64String(Properties.Settings.Default.CertPass));
                        certificado = new X509Certificate2(cert.GetRawCertData(), "");
                        certificado.PrivateKey = cert.PrivateKey;

                        break;
                    }
                }

                if (certificado == null)
                {
                    MessageBox.Show("Verificar Certificado de Token, o conexión de Token al pc", "No se encuentra Certificado", MessageBoxButtons.OK);
                    return;
                }

                store.Close();

                firmado.SigningKey = certificado.PrivateKey;
                firmado.SignedInfo.SignatureMethod = SignedXml.XmlDsigRSASHA1Url;

                //referencias
                Reference referencia = new Reference();
                if (tipoDoc == "adu")
                {
                    referencia.Uri = "#Documento101";
                }
                else if (tipoDoc == "compl")
                {
                    referencia.Uri = "#Documento101Compl";
                }
                else if (tipoDoc == "dt")
                {
                    referencia.Uri = "#Documento203";
                }
                else if (tipoDoc == "ds")
                {
                    referencia.Uri = "#Documento201";
                }
                else if (tipoDoc == "ip")
                {
                    referencia.Uri = "#Documento104";
                }
                else if (tipoDoc == "sve")
                {
                    referencia.Uri = "#Documento403";
                }

                //se agrega referencia al firmado
                firmado.AddReference(referencia);
                KeyInfo keyInfo = new KeyInfo();
                keyInfo.AddClause(new RSAKeyValue((RSA)certificado.PrivateKey));
                keyInfo.AddClause(new KeyInfoX509Data(certificado));
                firmado.KeyInfo = keyInfo;

                //se saca el calculo
                firmado.ComputeSignature();

                //XmlElement xmlDigitalSignature = firmado.GetXml();
                XmlElement xmlDigitalSignature = null;
                xmlDigitalSignature = firmado.GetXml();

                //busco la ubicación para poner la firma
                XmlElement elemento = null;
                if (tipoDoc == "adu")
                {
                    elemento = (XmlElement)documento.SelectSingleNode(@"//Document/Content/adu/TmstFirma[last()]");
                }
                else if (tipoDoc == "compl")
                {
                    elemento = (XmlElement)documento.SelectSingleNode(@"//Document/Content/compl/TmstFirma[last()]");
                }
                else if (tipoDoc == "dt")
                {
                    elemento = (XmlElement)documento.SelectSingleNode(@"//Document/Content/dt/TmstFirma[last()]");
                }
                else if (tipoDoc == "ds")
                {
                    elemento = (XmlElement)documento.SelectSingleNode(@"//Document/Content/ds/TmstFirma[last()]");
                }
                else if (tipoDoc == "ip")
                {
                    elemento = (XmlElement)documento.SelectSingleNode(@"//Document/Content/ip/TmstFirma[last()]");
                }
                else if (tipoDoc == "sve")
                {
                    elemento = (XmlElement)documento.SelectSingleNode(@"//Document/Content/adu/TmstFirma[last()]");
                }

                //inserto la firma
                XmlNode parent = elemento.ParentNode;
                parent.InsertAfter(xmlDigitalSignature, elemento);

                //declaracion de la ruta del archivo
                string ruta_completa = "";
                if (tipoDoc == "adu")
                {
                    ruta_completa = $@"{RutaPrincipal}{file1}-Firmado.xml";
                    Process.Start("explorer.exe", $"{RutaPrincipal}");
                    //Process.Start(@"http://sva.avansis.cl/conexion");
                }
                else if (tipoDoc == "compl")
                {
                    ruta_completa = $@"{RutaPrincipal}{file2}-Firmado.xml";
                }
                else if (tipoDoc == "dt")
                {
                    ruta_completa = $@"{RutaPrincipal}-Firmado.xml";
                }
                else if (tipoDoc == "ds")
                {
                    ruta_completa = $@"{RutaPrincipal}{file1}-Firmado.xml";
                }
                else if (tipoDoc == "ip")
                {
                    ruta_completa = $@"{RutaPrincipal}Produccion-Firmado.xml";
                }
                else if (tipoDoc == "sve")
                {
                    ruta_completa = $@"{RutaPrincipal}{file1}-Firmado.xml";
                    Process.Start("explorer.exe", $"{RutaPrincipal}");
                    //Process.Start(@"http://sva.avansis.cl/conexion");
                }

                //Se guarda el archivo
                XmlWriter writer = XmlWriter.Create(ruta_completa, _xmlWriterSettings);
                documento.Save(writer);
                writer.Close();

            }
            catch
            {
                MessageBox.Show("Tipo de archivo inválido");
            }
            
        }
        // VALIDA UNIDADES VACIAS O NULAS
        public void ValidaVacioONulo(object obj)
        {
            var properties = obj.GetType().GetProperties();

            foreach (var item in properties)
            {
                if (item.GetValue(obj).ToString() == "" || item.GetValue(obj) == null)
                    item.SetValue(null, null);
            }
        }
    }
}