using EjemploObservador.Interfaces;
using System;

namespace EjemploObservador
{
    class ObjeEnviarCorreoNot : ICorreoNotificador
    {
        public void enviarnotificacion(IAzureEjemplo azureEjemplo)
        {
            //if(Se finalizan compilaciones correctamente)
            //{
            Console.WriteLine("Se envia Correo de Actualización...");
            // }
        }
    }
}
