using PatronDecorador.Decorador.Interfaces;
using PatronDecorador.DTO;

namespace PatronDecorador.Decorador
{
    public abstract class DecoradorGuardarCxP : IDecoradorGuardarCxP
    {
        private readonly IDecoradorGuardarCxP _guardarCxP;

        public DecoradorGuardarCxP(IDecoradorGuardarCxP guardarCxP)
        {
            _guardarCxP = guardarCxP;
        }

        public virtual string RealizarOperacionCxP(CuentaXpagar cxp)
        {
            return _guardarCxP.RealizarOperacionCxP(cxp);
        }
    }
}
