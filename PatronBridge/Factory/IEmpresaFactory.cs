using PatronBridge.Empresa;
using PatronBridge.Transporte.Interfaces;

namespace PatronBridge.Factory
{
    public interface IEmpresaFactory
    {
        Empresas CrearInstancia(int iTipo, ITipoEnvio tipoEnvio, string cProducto); 
    }
}
