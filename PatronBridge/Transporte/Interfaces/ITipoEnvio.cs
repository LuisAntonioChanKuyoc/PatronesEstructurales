namespace PatronBridge.Transporte.Interfaces
{
    public interface ITipoEnvio
    {
        void procesarEnvio();
        void enviar();
        void procesarEntrega();
        void FinalizarEnvio(string cProducto);
    }
}
