using EjemploObservador.Interfaces;
using System;

namespace EjemploObservador
{
    class ObsSubirCodigo : ICorreoNotificador
    {
        public void enviarnotificacion(IAzureEjemplo azureEjemplo)
        {
            //if(todo correcto se sube codigo)
            //{
            Console.WriteLine("Se Sube Código...");
            //}
        }
    }
}
