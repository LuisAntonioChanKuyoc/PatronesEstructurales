using PatronBridge.Transporte;
using PatronBridge.Transporte.Interfaces;

namespace PatronBridge.Factory
{
    public class TransporteFactory : ITransporteFactory
    {
        public ITipoEnvio CrearInstancia(int iTipo)
        {
            ITipoEnvio tipoEnvio = null;

            switch (iTipo)
            {
                case 1:
                    tipoEnvio = new Avion();
                    break;
                case 2:
                    tipoEnvio = new Tren();
                    break;
                case 3:
                    tipoEnvio = new Barco();
                    break;
                default:
                    break;
            }

            return tipoEnvio;
        }
    }
}
