using PatronBridge.Empresa;
using PatronBridge.Transporte.Interfaces;

namespace PatronBridge.Factory
{
    public class EmpresaFactory : IEmpresaFactory
    {
        public Empresas CrearInstancia(int iTipo, ITipoEnvio tipoEnvio, string cProducto)
        {
            Empresas empresa = null;

            switch (iTipo)
            {
                case 1:
                    empresa = new DHL(tipoEnvio, cProducto);
                    break;
                case 2:
                    empresa = new Fedex(tipoEnvio, cProducto);

                    break;
                case 4:
                    empresa = new Estafeta(tipoEnvio, cProducto);

                    break;
            }

            return empresa;
        }
    }
}
