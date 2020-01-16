using EjemploObservador.Interfaces;
using System;

namespace EjemploObservador
{
    class ObsCompilar : ICorreoNotificador
    {
        public void enviarnotificacion(IAzureEjemplo azureEjemplo)
        {
            //if (No se obtuvo errores)
            //{
                Console.WriteLine("Se ha compilado correctamente...");
            //}
        }
    }
}
