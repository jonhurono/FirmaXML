using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FirmaXML.Entities.Aduana
{
    [Serializable]
    [XmlRoot("Document", Namespace = "")]

    public class DocumentoComplementario
    {
        //[XmlAttributeAttribute("complemento")]
        //public string complemento = "https://zf.defacto.cl/arch/xsd";

        //[XmlAttributeAttribute("targetNamespace")]
        //public string target = "https://zf.defacto.cl/arch/xsd";

        [XmlAttribute("Domain")]
        public string domain = "ZFrancaSVE";

        [XmlAttribute("Type")]
        public string type = "101";

        [XmlElement("Signers", Order = 1)]
        public List<SignersXMLComplemento> Signers_XML { get; set; }

        [XmlElement("Content", Order = 2)]
        public List<ContentXMLComplemento> Content_XML { get; set; }

    }

    #region Signers Complemento
    public class SignersXMLComplemento
    {
        [XmlElement("Signer", Order = 1)]
        public List<SignerXMLComplemento> Signer_XML { get; set; }

    }

    public class SignerXMLComplemento
    {
        [XmlElement("PI", Order = 1)]
        public List<PIXMLComplemento> PI { get; set; }
    }

    public class PIXMLComplemento
    {
        [XmlAttribute("Type")]
        public string type { get; set; }
    }
    #endregion


    #region Content Complemento
    public class ContentXMLComplemento
    {
        [XmlElement("compl", Order = 1)]
        public List<complXML> compl_XML { get; set; }
    }

    public class complXML
    {
        [XmlElement("documento", Namespace = "https://zf.defacto.cl/arch/xsd", Order = 1)]
        public List<DocumentoXMLComplemento> Documento_XML_com { get; set; }

        [XmlElement("URI", Order = 2)]
        public string uri = "";

        [XmlElement("TmstFirma", Order = 3)]
        public string tmsfirma = "";
    }
    #endregion

    #region Documento XML Complemento
    public class DocumentoXMLComplemento
    {
        [XmlAttribute("ID")]
        public string ID_com { get; set; }

        [XmlAttribute("xmlns")]
        public string xmlns_com { get; set; }

        [XmlElement("tipo_documento_codigo", Order = 1)]
        public string tipo_documento_codigo { get; set; }

        [XmlElement("tipo_operacion_codigo", Order = 2)]
        public string tipo_operacion_codigo { get; set; }

        [XmlElement("presentacion_zona_franca_codigo", Order = 3)]
        public string presentacion_zona_franca_codigo { get; set; }

        [XmlElement("presentacion_aduana_codigo", Order = 4)]
        public int presentacion_aduana_codigo { get; set; }

        [XmlElement("origen_aduana_codigo", Order = 5)]
        public int origen_aduana_codigo { get; set; }

        [XmlElement("usuario_zf", Order = 6)]
        public List<Usuario_zf_XML> Usuario_ZF { get; set; }

        [XmlElement("representantes", Order = 7)]
        public List<Representantes_DocCom> Representantes_Doc { get; set; }
    }
    #endregion


    #region Usuario_Documento_Complementario
    public class Usuario_zf_XML
    {
        [XmlElement("usuario_nombre", Order = 1)]
        public string usuario_nombre { get; set; }

        [XmlElement("usuario_direccion", Order = 2)]
        public string usuario_direccion { get; set; }

        [XmlElement("usuario_correo", Order = 3)]
        public string usuario_correo { get; set; }

        [XmlElement("usuario_contrato_numero", Order = 4)]
        public string usuario_contrato_numero { get; set; }

        [XmlElement("usuario_contrato_fecha", Order = 5)]
        public string usuario_contrato_fecha { get; set; }
    }
    #endregion

    #region Datos del representante para el documento complementario
    public class Representantes_DocCom
    {
        [XmlElement("representante")]
        public List<Representante_DocCom> representante { get; set; }
    }
    #endregion

    #region Datos del representante para el documento complementario
    public class Representante_DocCom
    {
        [XmlElement("representante_tipo", Order = 1)]
        public string representante_tipo { get; set; }

        [XmlElement("representante_codigo", Order = 2)]
        public string representante_codigo { get; set; }

        [XmlElement("representante_rut", Order = 3)]
        public int representante_rut { get; set; }

        [XmlElement("representante_rut_dv", Order = 4)]
        public string representante_rut_dv { get; set; }

        [XmlElement("representante_nombre", Order = 5)]
        public string representante_nombre { get; set; }
    }
    #endregion

}
