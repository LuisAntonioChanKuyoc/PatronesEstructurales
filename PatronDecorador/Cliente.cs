using System;
using PatronDecorador.Acciones;
using PatronDecorador.DTO;
using PatronDecorador.Repositorio;
using PatronDecorador.Validadores;

namespace PatronDecorador
{
    public class Cliente
    {
        private readonly IValidador _validador;

        public Cliente(IValidador validador)
        {
            _validador = validador;
        }

        public void Main()
        {
            CuentaXpagar cxp = new CuentaXpagar
            {
                cIdUnidadAdministrativa = ObtenerUnidadAdministrativa(),
                dImporte = _validador.ValidadorDouble("Agregar importe"),
                iIdCuentaXPagar = _validador.ValidadorInt("Agregar identificador"),
                lActivo = _validador.ValidadorBool("Agregar Estatus"),
                lNaturaleza = ObtenerNaturaleza()
            };

            GuardarCxP GuardarCxP = new GuardarCxP();

            var RepositorioCxP = new RepositorioCxP(GuardarCxP);
            RepositorioCxP.GuardarCxP(cxp);


            VerificarEstatusParaCorreo(cxp, GuardarCxP);
            VerificarNaturalezaParaHistorial(cxp, GuardarCxP);
        }

        public void VerificarEstatusParaCorreo(CuentaXpagar cxp, GuardarCxP GuardarCxP)
        {
            if (!cxp.lActivo)
            {
                var correo = new EnviarCorreo(GuardarCxP);
                RepositorioCxP RepositorioCxP = new RepositorioCxP(correo);
                RepositorioCxP.GuardarCxP(cxp);
            }
        }

        public void VerificarNaturalezaParaHistorial(CuentaXpagar cxp, GuardarCxP GuardarCxP)
        {
            if (!cxp.lNaturaleza)
            {
                var historial = new GuardarHistorial(GuardarCxP);
                RepositorioCxP RepositorioCxP = new RepositorioCxP(historial);
                RepositorioCxP.GuardarCxP(cxp);
            }
        }

        public string ObtenerUnidadAdministrativa()
        {

            Console.WriteLine("Agregar Unidad Administrativa: ");
            return Console.ReadLine();

        }

        public bool ObtenerNaturaleza()
        {
            bool lNaturaleza;

            do
            {
                int iNaturaleza = _validador.ValidadorInt("Ingresa la naturaleza de la cxp\n1. Suma\n0. Resta");
                if (iNaturaleza == 1 || iNaturaleza == 0)
                {
                    lNaturaleza = iNaturaleza == 1;
                    break;
                }
                else
                {
                    Console.WriteLine("Solo se permite numero 1 o 0.");

                }
            } while (true);

            return lNaturaleza;
        }
    }
}
