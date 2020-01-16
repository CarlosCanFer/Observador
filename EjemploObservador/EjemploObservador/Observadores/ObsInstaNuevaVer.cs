using EjemploObservador.Interfaces;
using System;

namespace EjemploObservador
{
    class ObsInstaNuevaVer : ICorreoNotificador
    {
        public void enviarnotificacion(IAzureEjemplo azureEjemplo)
        {
            //if(se compila correctamente se)
            //{
            Console.WriteLine("Se Istala la nueva versión...");
            // }
        }
    }
}
