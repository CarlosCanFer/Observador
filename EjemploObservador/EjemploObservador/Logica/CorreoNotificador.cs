using EjemploObservador.Interfaces;

namespace EjemploObservador
{
    public class CorreoNotificador 
    {        
        public void enviarnotificacion(string _ccodigo, string _cdescripcion)
        {
            IVisualizarMensaje objmensaje = new VisualizarMensaje();
            string _cmensaje;
            _cmensaje = "\nSe creó: " + _ccodigo + " con la siguiente descripción: " + _cdescripcion;
            objmensaje.mostrarmensaje(_cmensaje);
        }
    }
}
