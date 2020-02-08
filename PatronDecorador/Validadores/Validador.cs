using System;

namespace PatronDecorador.Validadores
{
    public class Validador : IValidador
    {
        public bool ValidadorBool(string cMensaje)
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

        public double ValidadorDouble(string cMensaje)
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

        public int ValidadorInt(string cMensaje)
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
