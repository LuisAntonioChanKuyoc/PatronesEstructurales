using PatronAdaptador.Entidad;

namespace PatronAdaptador.Lugar.Interfaces
{
    /// <summary>
    /// Interfaces que se identifica el lugar donde se obtendra el requerimiento
    /// </summary>
    public interface ILugar
    {
        /// <summary>
        /// Obtiene el requerimiento de una lista de estas.
        /// </summary>
        /// <param name="iIdRequerimiento">Identificador del requerimiento</param>
        /// <returns>Requerimiento encontrado</returns>
        RequerimientosDTO ObtenerRequerimientos(int iIdRequerimiento);
    }
}
