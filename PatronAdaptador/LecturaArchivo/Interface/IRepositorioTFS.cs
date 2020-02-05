namespace PatronAdaptador.LecturaArchivo.Interface
{
    public interface IRepositorioTFS
    {
        /// <summary>
        /// Método que simula al repositorio del TFS donde se encuentran los requerimientos registrados
        /// </summary>
        /// <param name="cPath">Ubicación del repositorio</param>
        /// <returns>Una cadena de contiene formato json que se obtiene del repositorio</returns>
        string ListarRequerimientosTFS(string cPath);

    }
}
