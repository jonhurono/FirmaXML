using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FirmaXML.Entities.Aduana
{
    [Serializable]
    [XmlRoot("Document")]
    public class DocumentoIngresoRaiz
    {
        [XmlAttribute("Domain")]
        public string domain = "ZFrancaSVE";

        [XmlAttribute("Type")]
        public string type = "101";

        [XmlElement("Signers", Order = 1)]
        public List<SignersXML> Signers_XML { get; set; }

        [XmlElement("Content", Order = 2)]
        public List<ContentXML> Content_XML { get; set; }
    }

    public class SignersXML
    {
        [XmlElement("Signer", Order = 1)]
        public List<SignerXML> Signer_XML { get; set; }

    }

    public class SignerXML
    {
        [XmlElement("PI", Order = 1)]
        public List<PIXML> PI { get; set; }
    }

    public class PIXML
    {
        [XmlAttribute("Type")]
        public string type { get; set; }
    }

    public class ContentXML
    {
        [XmlElement("adu", Order = 1)]
        public List<sveXML> sve_XML { get; set; }
    }

    public class sveXML
    {
        [XmlElement("documento", Namespace = "http://www.aduana.cl/xml/esquemas/zf/ingreso/v2", Order = 1)]
        public List<DocumentoXML> Documento_XML { get; set; }

        [XmlElement("URI", Order = 2)]
        public string uri = "";

        [XmlElement("TmstFirma", Order = 3)]
        public string tmsfirma = "";
    }

    public class DocumentoXML
    {
        [XmlAttribute]
        public string ID { get; set; }

        [XmlAttribute("xmlns")]
        public string xmlns { get; set; }

        [XmlElement("cabecera", Order = 1)]
        public List<CabeceraXML> Cabecera { get; set; }

        [XmlElement("documentosadjuntos", Order = 2)]
        public List<DocumentosAdjuntosXML> Documentos_Adjuntos { get; set; }

        [XmlElement("bultos", Order = 3)]
        public List<BultosXML> Bultos { get; set; }

        [XmlElement("contenedores", Order = 4)]
        public List<ContenedoresXMLR> Contenedores { get; set; }

        [XmlElement("detalle", Order = 5)]
        public List<DetalleXML> Detalle { get; set; }
    }

    #region Cabecera
    public class CabeceraXML
    {
        [XmlElement("garantia_numero", Order = 1, IsNullable = true)]
        public string garantia_numero { get; set; }

        [XmlElement("informacion_adicional", Order = 2, IsNullable = true)]
        public string informacion_adicional { get; set; }

        [XmlElement("procedencia_codigo", Order = 3)]
        public string procedencia_codigo { get; set; }

        [XmlElement("numero_provisorio", Order = 4, IsNullable = true)]
        public string numero_provisorio { get; set; }

        [XmlElement("region_codigo", Order = 5, IsNullable = true)]
        public string region_codigo { get; set; }

        [XmlElement("numero_interno_usuario", Order = 6)]
        public string numero_interno_usuario { get; set; }

        [XmlElement("pais_codigo", Order = 7, IsNullable = true)]
        public string pais_codigo { get; set; }

        [XmlElement("zona_franca_extension_codigo", Order = 8, IsNullable = true)]
        public string zona_franca_extension_codigo { get; set; }

        [XmlElement("centro_exportacion_codigo", Order = 9, IsNullable = true)]
        public string centro_exportacion_codigo { get; set; }

        [XmlElement("zona_franca_otra_codigo", Order = 10, IsNullable = true)]
        public string zona_franca_otra_codigo { get; set; }

        [XmlElement("glosa", Order = 11)]
        public string glosa { get; set; }

        [XmlElement("usuario_rut_numero", Order = 12)]
        public string usuario_rut_numero { get; set; }

        [XmlElement("usuario_rut_dv", Order = 13)]
        public string usuario_rut_dv { get; set; }

        [XmlElement("puerto_embarque_codigo", Order = 14, IsNullable = true)]
        public string puerto_embarque_codigo { get; set; }

        [XmlElement("tipo_tramite_codigo", Order = 15, IsNullable = true)]
        public string tipo_tramite_codigo { get; set; }

        [XmlElement("ubicacion_destino_codigo", Order = 16)]
        public string ubicacion_destino_codigo { get; set; }

        [XmlElement("moneda_codigo", Order = 17)]
        public string moneda_codigo { get; set; }

        [XmlElement("medio_transporte_codigo", Order = 18, IsNullable = true)]
        public string medio_transporte_codigo { get; set; }

        [XmlElement("pais_origen", Order = 19, IsNullable = true)]
        public string pais_origen { get; set; }

        [XmlElement("valor_fob", Order = 20, IsNullable = true)]
        public string valor_fob { get; set; }

        [XmlElement("valor_flete", Order = 21, IsNullable = true)]
        public string valor_flete { get; set; }

        [XmlElement("valor_seguro", Order = 22, IsNullable = true)]
        public string valor_seguro { get; set; }

        [XmlElement("valor_cif", Order = 23, IsNullable = true)]
        public string valor_cif { get; set; }

        [XmlElement("monto_operacion", Order = 24, IsNullable = true)]
        public string monto_operacion { get; set; }

        [XmlElement("clausula", Order = 25, IsNullable = true)]
        public string clausula { get; set; }

        [XmlElement("transbordo_nacional", Order = 26, IsNullable = true)]
        public string transbordo_nacional { get; set; }

        [XmlElement("transbordo_extranjero", Order = 27, IsNullable = true)]
        public string transbordo_extranjero { get; set; }

        [XmlElement("almacenista", Order = 28, IsNullable = true)]
        public string almacenista { get; set; }

        [XmlElement("ubicacion_zona_primaria", Order = 29, IsNullable = true)]
        public string ubicacion_zona_primaria { get; set; }

        public static implicit operator List<object>(CabeceraXML v)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Documentos Adjuntos
    public class DocumentosAdjuntosXML
    {
        [XmlElement("documentoadjunto")]
        public List<DocumentoAdjuntoXML> documento_adjunto { get; set; }
    }

    public class DocumentoAdjuntoXML
    {
        [XmlElement("tipo_codigo", Order = 1)]
        public string tipo_codigo { get; set; }

        [XmlElement("numero_documento", Order = 2)]
        public string numero_documento { get; set; }

        [XmlElement("fecha_documento", Order = 3, IsNullable = true)]
        public string fecha_documento { get; set; }

        [XmlElement("emisor", Order = 4)]
        public string emisor { get; set; }

        [XmlElement("aduana_origen_codigo", Order = 5, IsNullable = true)]
        public string aduana_origen_codigo { get; set; }

        //[XmlElement("rut_numero", Order = 6, IsNullable = true)]
        //public string rut_numero { get; set; }

        //[XmlElement("rut_dv", Order = 7, IsNullable = true)]
        //public string rut_dv { get; set; }

        [XmlElement("rut_numero", Order = 6)]
        public string rut_numero { get; set; }

        [XmlElement("rut_dv", Order = 7)]
        public string rut_dv { get; set; }

    }
    #endregion

    #region Bultos
    public class BultosXML
    {
        [XmlElement("bulto")]
        public List<BultoXML> Bulto { get; set; }
    }

    public class BultoXML
    {
        [XmlElement("tipo_bulto_codigo", Order = 1)]
        public string tipo_bulto_codigo { get; set; }

        [XmlElement("cantidad_bulto", Order = 2)]
        public string cantidad_bulto { get; set; }

        [XmlElement("peso_bulto", Order = 3)]
        public decimal peso_bulto { get; set; }

        [XmlElement("descripcion_bulto", Order = 4)]
        public string descripcion_bulto { get; set; }
    }
    #endregion

    #region Contenedores
    public class ContenedoresXMLR
    {
        [XmlElement("contenedor")]
        public List<ContenedorXML> contenedor { get; set; }
    }

    public class ContenedorXML
    {
        [XmlElement("contenedor_tipo_codigo", Order = 1)]
        public string contenedor_tipo_codigo { get; set; }

        [XmlElement("contenedor_numero", Order = 2)]
        public string contenedor_numero { get; set; }
    }
    #endregion

    #region Detalle
    public class DetalleXML
    {
        [XmlElement("item")]
        public List<ItemXML> Items { get; set; }
    }
    #endregion

    #region Detalle - Item
    public class ItemXML
    {
        [XmlElement("nro_item", Order = 1)]
        public int nro_item { get; set; }

        [XmlElement("codigo_arancelario", Order = 2)]
        public string codigo_arancelario { get; set; }

        [XmlElement("cantidad_unidad_medida_arancelaria", Order = 3)]
        public decimal cantidad_unidad_medida_arancelaria { get; set; }

        [XmlElement("unidad_medida_codigo", Order = 4)]
        public string unidad_medida_codigo { get; set; }

        [XmlElement("unidades_set", Order = 5, IsNullable = true)]
        public string unidades_set { get; set; }

        [XmlElement("cantidad", Order = 6)]
        public decimal cantidad { get; set; }

        [XmlElement("total_valor_cif", Order = 7, IsNullable = true)]
        public string total_valor_cif { get; set; }

        [XmlElement("total_valor_ingreso", Order = 8, IsNullable = true)]
        public string total_valor_ingreso { get; set; }

        [XmlElement("autorizaciones_organismos_externos", Order = 9, IsNullable = true)]
        public List<AutorizacionesOrganismosExternosXML> AutorizacionesOrganismosExternos;

        [XmlElement("pdm_codigo", Order = 10, IsNullable = true)]
        public string pdm_codigo { get; set; }

        [XmlElement("descriptores", Order = 11, IsNullable = true)]
        public List<DescriptoresXML> Descriptores;



    }

    public class AutorizacionesOrganismosExternosXML
    {
        [XmlElement("autorizacion_organismos_externos")]
        public List<AutorizacionOrganismoExternoXML> autorizacion_organismos_externos { get; set; }
    }

    public class AutorizacionOrganismoExternoXML
    {
        [XmlElement("declara_certificado", Order = 1)]
        public string declara_certificado { get; set; }

        [XmlElement("organismo_externo_codigo", Order = 2)]
        public string organismo_externo_codigo { get; set; }

        [XmlElement("tipo", Order = 3)]
        public string tipo { get; set; }

        [XmlElement("numero", Order = 4)]
        public string numero { get; set; }

        [XmlElement("fecha", Order = 5)]
        public string fecha { get; set; }

        [XmlElement("glosa_autorizacion", Order = 6, IsNullable = true)]
        public string glosa_autorizacion { get; set; }

    }

    public class DescriptoresXML
    {
        [XmlElement("descriptor")]
        public List<DescriptorXML> descriptor { get; set; }
    }

    public class DescriptorXML
    {
        [XmlElement("descriptor_codigo", Order = 1)]
        public string descriptor_codigo { get; set; }

        [XmlElement("descriptor_valor", Order = 2)]
        public string descriptor_valor { get; set; }
    }
    #endregion
}
