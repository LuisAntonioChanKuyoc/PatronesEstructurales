using PatronBridge.Transporte.Interfaces;

namespace PatronBridge.Empresa
{
    public class Estafeta : Empresas
    {
        public Estafeta(ITipoEnvio tipoEnvio, string cProducto) : base(tipoEnvio, cProducto)
        {
        }
    }
}
