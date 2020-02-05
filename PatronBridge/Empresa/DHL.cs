using PatronBridge.Transporte.Interfaces;

namespace PatronBridge.Empresa
{
    public class DHL : Empresas
    {
        public DHL(ITipoEnvio tipoEnvio, string cProducto) : base(tipoEnvio, cProducto)
        {
        }
    }
}
