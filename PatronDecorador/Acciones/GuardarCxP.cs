using PatronDecorador.Decorador.Interfaces;
using PatronDecorador.DTO;

namespace PatronDecorador.Acciones
{
    public class GuardarCxP : IDecoradorGuardarCxP
    {
        public string RealizarOperacionCxP(CuentaXpagar cxp)
        {
            return $"Se ha guardado la cuenta por pagar {cxp.iIdCuentaXPagar} por la cantidad de ${cxp.dImporte} pesos, con la unidad administrativa {cxp.cIdUnidadAdministrativa}";
        }
    }
}
