using PatronBridge.Transporte.Interfaces;

namespace PatronBridge.Factory
{
    public interface ITransporteFactory
    {
        ITipoEnvio CrearInstancia(int iTipo);
    }
}
