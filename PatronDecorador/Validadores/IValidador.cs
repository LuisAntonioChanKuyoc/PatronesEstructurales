namespace PatronDecorador.Validadores
{
    public interface IValidador
    {
        int ValidadorInt(string cMensaje);
        double ValidadorDouble(string cMensaje);
        bool ValidadorBool(string cMensaje);
    }
}
