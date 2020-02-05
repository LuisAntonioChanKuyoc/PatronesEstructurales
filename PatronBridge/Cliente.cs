using PatronBridge.Empresa;
using PatronBridge.Transporte;
using System;
using System.Collections.Generic;

namespace PatronBridge
{
    public class Cliente
    {
        public void Main()
        {
            List<Empresas> lstempresas = new List<Empresas>() {
            new DHL(new Barco(),"Tenis"),
            new DHL(new Avion(),"Corbata"),
            new Fedex(new Tren(),"Reloj"),
            new Fedex(new Avion(),"Computadora"),
            new Estafeta(new Tren(),"Playera"),
            new Estafeta(new Avion(),"Cables"),
            new Estafeta(new Barco(),"Celular"),
            };

            foreach (var empresas in lstempresas)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"El paquete se ha enviado mediante {empresas.GetType().Name} empresa de mensajería.\n");
                IniciarMensajeria(empresas);
            }

        }

        public void IniciarMensajeria(Empresas empresas)
        {
            
            empresas.recogerPaquete();

            empresas.enviarPaquete();

            empresas.entregarPaquete();

            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
