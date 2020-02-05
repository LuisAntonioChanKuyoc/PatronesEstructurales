using Newtonsoft.Json;
using PatronAdaptador.Entidad;
using PatronAdaptador.LecturaArchivo.Interface;
using System.Collections.Generic;
using System.Linq;

namespace PatronAdaptador.Lugar
{
    public class LugarTFS
    {
        private readonly IRepositorioTFS _repositorioTFS;

        /// <summary>
        /// Constructor para instanciar los repositorios
        /// </summary>
        /// <param name="repositorioTFS">Repositorio del TFS</param>
        public LugarTFS(IRepositorioTFS repositorioTFS)
        {
            _repositorioTFS = repositorioTFS;
        }

        /// <summary>
        /// Obtiene el requerimiento de una lista de estas.
        /// </summary>
        /// <param name="iIdRequerimiento">Identificador del requerimiento</param>
        /// <returns>Requerimiento encontrado</returns>
        public RequerimientosDTO ListarRequerimientos(int iIdRequerimiento)
        {
            string cRuta = @"C:\BLUE_OCEAN\Capacitacion\PatronesEstructurales\Requerimientos.json"; //Simula la dirección del repositorio del TFS

            string lista = _repositorioTFS.ListarRequerimientosTFS(cRuta);

            List<RequerimientosDTO> lstRequerimiento = ConvertirJsonALista(lista);

            return lstRequerimiento.FirstOrDefault(z=>z.iIdRequerimiento==iIdRequerimiento);
        }

        /// <summary>
        /// Método que convierte una cadena que contiene un json a una lista con sus debidas propiedades
        /// </summary>
        /// <param name="lista">Lista de requerimientos que se encuentra en una cadena</param>
        /// <returns>Lista de requerimientos con sus debidas propiedades</returns>
        public List<RequerimientosDTO> ConvertirJsonALista(string lista)
        {
            List<RequerimientosDTO> lstRequerimiento = (List<RequerimientosDTO>)JsonConvert.DeserializeObject(lista, typeof(List<RequerimientosDTO>));

            return lstRequerimiento;
        }
    }
}
