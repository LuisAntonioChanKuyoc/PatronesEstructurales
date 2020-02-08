using System;

namespace PatronDecorador.Validadores
{
    public class ValidadorInt
    {
        public int VerificarValor(string cMensaje)
        {
            int iIdentificador;

            do
            {
                Console.WriteLine($"{cMensaje}: ");
                if (int.TryParse(Console.ReadLine(), out iIdentificador))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Solo se permiten números enteros.");
                }

            } while (true);

            return iIdentificador;
        }
    }
}
