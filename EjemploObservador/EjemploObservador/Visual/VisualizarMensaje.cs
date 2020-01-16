using EjemploObservador.Interfaces;
using System;

namespace EjemploObservador
{
    public class VisualizarMensaje : IVisualizarMensaje
    {
        public void mostrarmensaje(string _cmensaje)
        {
            Console.WriteLine(_cmensaje);
        }
    }
}
