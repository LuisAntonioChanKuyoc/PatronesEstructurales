using PatronDecorador.Decorador.Interfaces;
using PatronDecorador.DTO;
using System;

namespace PatronDecorador.Repositorio
{
    public class RepositorioCxP
    {
        private readonly IDecoradorGuardarCxP _guardarCxP;

        public RepositorioCxP(IDecoradorGuardarCxP guardarCxP)
        {
            _guardarCxP = guardarCxP;
        }

        public void GuardarCxP(CuentaXpagar cxp)
        {
            Console.WriteLine(_guardarCxP.RealizarOperacionCxP(cxp));
        }
    }
}
