using System;

namespace PatronDecorador.Validadores
{
    public class ValidadorBool
    {
        public bool VerificarValor(string cMensaje)
        {
            bool lActivo;

            do
            {
                Console.WriteLine($"{cMensaje}: ");
                if (bool.TryParse(Console.ReadLine(), out lActivo))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Solo se permite booleano (true o false).");
                }

            } while (true);

            return lActivo;
        }
    }
}
