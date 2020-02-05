using PatronBridge.Transporte.Interfaces;
using System;

namespace PatronBridge.Transporte
{
    public class Avion : ITipoEnvio
    {
        /// <summary>
        /// Método para que muestra el inicio del envió
        /// </summary>
        public void procesarEnvio()
        {
            Console.WriteLine("El paquete se ha cargado en el Avión.");
        }

        /// <summary>
        /// Método que muestra el mensaje cuando el paquete ha salido con el transporte
        /// </summary>
        public void enviar()
        {
            Console.WriteLine("El Avión ha salido con el paquete.");
        }

        /// <summary>
        /// Método que muestra el mensaje cuando se ha llegado el paquete
        /// </summary>
        public void procesarEntrega()
        {
            Console.WriteLine("El Avión ha llegado al destino y se ha descargado.");
        }

        /// <summary>
        /// Método que muestra el mensaje cuando se ha finalizado la entrega
        /// </summary>
        /// <param name="cProducto">Nombre del producto</param>
        public void FinalizarEnvio(string cProducto)
        {
            Console.WriteLine($"El {cProducto} se ha entregado");
        }
    }
}
