namespace EjemploObservador.Interfaces
{
    public interface IAzureEjemplo
    {
        void Agregar(ICorreoNotificador observador);

        void Quitar(ICorreoNotificador observador);

        void Notificar();
    }
}
