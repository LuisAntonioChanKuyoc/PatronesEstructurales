using PatronAdaptador.LecturaArchivo.Interface;
using System.IO;

namespace PatronAdaptador.LecturaArchivo
{
    /// <summary>
    /// Clase que simula el repositorio del TFS y esta retorna un json 
    /// </summary>
    public class RepositorioTFS: IRepositorioTFS
    {
        /// <summary>
        /// Método que simula al repositorio del TFS donde se encuentran los requerimientos registrados
        /// </summary>
        /// <param name="cPath">Ubicación del repositorio</param>
        /// <returns>Una cadena de contiene formato json que se obtiene del repositorio</returns>
        public string ListarRequerimientosTFS(string cPath)
        {
            string eventos = File.ReadAllText(cPath);

            return eventos;
        }
    }
}
