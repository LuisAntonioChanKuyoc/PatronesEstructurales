namespace PatronAdaptador.Entidad
{
    /// <summary>
    /// Entidad para guardar la información del requerimiento
    /// </summary>
    public class RequerimientosDTO
    {
        public int iIdRequerimiento { get; set; }
        public int iTotalLinea { get; set; }
        public int iLineasCodificadas { get; set; }
        public string cNombreRequerimiento { get; set; }
    }
}
