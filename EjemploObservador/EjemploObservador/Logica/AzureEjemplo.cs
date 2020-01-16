using EjemploObservador.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;

namespace EjemploObservador
{
    public class AzureEjemplo : IAzureEjemplo
    {
        public int Estado { get; set; }

        private List<ICorreoNotificador> _observers = new List<ICorreoNotificador>();

        public void Agregar(ICorreoNotificador observador)
        {
            this._observers.Add(observador);
        }

        public void Notificar()
        {

            Console.WriteLine("Notificando observaciones...");

            foreach (var observer in _observers)
            {
                observer.enviarnotificacion(this);
            }
        }

        public void Quitar(ICorreoNotificador observador)
        {          
            this._observers.Remove(observador);
        }
       
        public void LogicadeNEgocio()
        {
            Console.WriteLine("\nEn proceso.");
            this.Estado = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Estado: " + this.Estado);
            this.Notificar();
        }
    }
}
