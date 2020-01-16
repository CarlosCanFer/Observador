using EjemploObservador.Interfaces;
using System;

namespace EjemploObservador
{
    class ObsPruebasunitarias : ICorreoNotificador
    {
        public void enviarnotificacion(IAzureEjemplo azureEjemplo)
        {
            //if(no hay errores de compilación de las pruebas)
            //{
            Console.WriteLine("Se Finaliza la compilación de las pruebas unitarias...");
           // }
           
        }
    }
}
