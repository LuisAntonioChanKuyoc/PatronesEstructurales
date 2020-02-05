using PatronAdaptador.Entidad;
using PatronAdaptador.LecturaArchivo;
using PatronAdaptador.Lugar.Interfaces;
using System;

namespace PatronAdaptador.Lugar.LugarAdapter
{
    public class LugarTFSAdapter : ILugar
    {
        private readonly LugarTFS _lugarTFS;
        public LugarTFSAdapter()
        {
            _lugarTFS = new LugarTFS(new RepositorioTFS());
            Console.WriteLine("Creado el adaptador para el tfs\n");
        }

        /// <summary>
        /// Obtiene el requerimiento de una lista de estas.
        /// </summary>
        /// <param name="iIdRequerimiento">Identificador del requerimiento</param>
        /// <returns>Requerimiento encontrado</returns>
        public RequerimientosDTO ObtenerRequerimientos(int iIdRequerimiento)
        {
            return _lugarTFS.ListarRequerimientos(iIdRequerimiento);
        }
    }
}
