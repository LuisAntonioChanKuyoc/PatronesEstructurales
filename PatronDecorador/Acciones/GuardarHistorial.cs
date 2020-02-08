using PatronDecorador.Decorador;
using PatronDecorador.Decorador.Interfaces;
using PatronDecorador.DTO;

namespace PatronDecorador.Acciones
{
    public class GuardarHistorial : DecoradorGuardarCxP
    {
        public GuardarHistorial(IDecoradorGuardarCxP guardarCxP) : base(guardarCxP)
        {
        }

        public override string RealizarOperacionCxP(CuentaXpagar cxp)
        {
            return $"Se ha guardado el historial de la cuenta por pagar {cxp.iIdCuentaXPagar} " +
                $"por la cantidad de ${cxp.dImporte} pesos, con la unidad administrativa {cxp.cIdUnidadAdministrativa}";
        }
    }
}
