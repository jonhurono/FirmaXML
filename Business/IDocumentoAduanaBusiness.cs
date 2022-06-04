using System;
using System.Collections.Generic;
using System.Text;

namespace FirmaXML.Business
{
    public interface IDocumentoAduanaBusiness
    {
    void Firmar(string tipoDocumento, string ubiXML1, string ubiXML2, string nameXML1, string nameXML2, string huella);
    }
}
