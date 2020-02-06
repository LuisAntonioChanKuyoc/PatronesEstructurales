using PatronBridge.Empresa;
using PatronBridge.Factory;
using PatronBridge.Transporte.Interfaces;
using System;

namespace PatronBridge
{
    public class Cliente
    {
        public void Main()
        {
            ITransporteFactory transporte = new TransporteFactory();
            IEmpresaFactory empresaFactory = new EmpresaFactory();

            do
            {
                ITipoEnvio tipoEnvio = transporte.CrearInstancia(ObtenerTransporte());
                int iEmpresa = ObtenerEmpresa();
                string cProducto = ObtenerProducto();
                Empresas empresa = empresaFactory.CrearInstancia(iEmpresa, tipoEnvio, cProducto);

                IniciarMensajeria(empresa);

            } while (true);
        }

        public void IniciarMensajeria(Empresas empresas)
        {

            empresas.recogerPaquete();

            empresas.enviarPaquete();

            empresas.entregarPaquete();

            Console.WriteLine("\n");
            Console.ReadKey();
        }

        public string ObtenerProducto()
        {
            Console.WriteLine("\nEscribe el nombre del producto:");
            return Console.ReadLine();
        }

        public int ObtenerEmpresa()
        {
            Console.WriteLine("\nEliga el número que corresponda a la empresa:" +
               "\n1. DHL" +
               "\n2. Fedex" +
               "\n3. Estafeta");

            return Convert.ToInt32(Console.ReadLine());

        }

        public int ObtenerTransporte()
        {
            Console.WriteLine("\nEliga el número que corresponda al tipo de transporte:" +
              "\n1. Barco" +
              "\n2. Tren" +
              "\n3. Avion");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
