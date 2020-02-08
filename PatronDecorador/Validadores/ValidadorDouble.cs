using System;

namespace PatronDecorador.Validadores
{
    public class ValidadorDouble
    {
        public double VerificarValor(string cMensaje)
        {
            double dImporte;

            do
            {
                Console.WriteLine($"{cMensaje}: ");
                if (double.TryParse(Console.ReadLine(), out dImporte))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Solo se permiten números enteros y decimales.");
                }

            } while (true);

            return dImporte;
        }
    }
}
