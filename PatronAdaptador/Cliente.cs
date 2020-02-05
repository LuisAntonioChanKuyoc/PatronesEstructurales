using PatronAdaptador.Entidad;
using PatronAdaptador.Lugar.Interfaces;
using PatronAdaptador.Lugar.LugarAdapter;
using System;

namespace PatronAdaptador
{
    public class Cliente
    {
        public void Main()
        {
            ILugar lugar = new LugarTFSAdapter();

            do
            {
                Console.WriteLine("\nIngresa el identificador del requerimiento (número):");

                if ((int.TryParse(Console.ReadLine(), out int iIdRequerimiento)))
                {
                    RequerimientosDTO Requerimiento = lugar.ObtenerRequerimientos(iIdRequerimiento);
                    MostarRequerimiento(Requerimiento);
                }
                else
                {
                    Console.WriteLine("\nIngrese un número valido");
                }


            } while (true);


        }

        public void MostarRequerimiento(RequerimientosDTO Requerimiento)
        {
            if (Requerimiento != null)
            {
                Console.WriteLine("Información del requerimiento=>\n" +
                $"Identificador del requerimiento: {Requerimiento.iIdRequerimiento}\n" +
                $"Nombre del requerimiento: {Requerimiento.cNombreRequerimiento}\n" +
                $"Total de lineas de código: {Requerimiento.iTotalLinea}\n" +
                $"Líneas de código reales codificadas:{Requerimiento.iLineasCodificadas}");
            }
            else
            {
                Console.WriteLine("\nNo se encontró ningún requerimiento con ese identificador");
            }
            

            Console.ReadKey();
        }
    }
}
