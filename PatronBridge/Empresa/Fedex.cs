using PatronBridge.Transporte.Interfaces;

namespace PatronBridge.Empresa
{
    public class Fedex : Empresas
    {
        public Fedex(ITipoEnvio tipoEnvio, string cProducto) : base(tipoEnvio, cProducto)
        {
        }
    }
}
