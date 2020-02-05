using PatronBridge.Transporte.Interfaces;
using System;

namespace PatronBridge.Empresa
{
    public abstract class Empresas
    {
        private readonly ITipoEnvio _tipoEnvio;
        private readonly string _cProducto;

        public Empresas(ITipoEnvio tipoEnvio, string cProducto)
        {
            _tipoEnvio = tipoEnvio;
            _cProducto = cProducto;
        }

        /// <summary>
        /// Serie de mensaje referente al tipo de transporte que se va utilizar
        /// </summary>
        public void recogerPaquete()
        {
            Console.WriteLine($"El {_cProducto} se ha recolectado y empaquetado.");

            _tipoEnvio.procesarEnvio();
        }

        /// <summary>
        /// Método que muestra el mensaje cuando se ha iniciado el envió del producto
        /// </summary>
        public void enviarPaquete()
        {
            Console.WriteLine($"El {_cProducto} se ha enviado.");
            _tipoEnvio.enviar();
        }

        /// <summary>
        /// Método que muestra el mensaje cuando se ha entregado el paquete
        /// </summary>
        public void entregarPaquete()
        {
            _tipoEnvio.procesarEntrega();

            Console.WriteLine($"El {_cProducto} está en camino de ser entregado.");

            _tipoEnvio.FinalizarEnvio(_cProducto);
        }
    }
}
