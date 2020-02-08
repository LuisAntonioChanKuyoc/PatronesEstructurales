using PatronDecorador.Validadores;
using System;

namespace PatronDecorador
{
    class Program
    {
        static void Main(string[] args)
        {
            IValidador validador = new Validador();
            new Cliente(validador).Main();
            Console.ReadKey();
        }
    }
}
