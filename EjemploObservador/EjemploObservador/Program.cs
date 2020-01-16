using System;

namespace EjemploObservador
{
    public class Program
    {
        static void Main(string[] args)
        {
            CorreoNotificador correoNotificador = new CorreoNotificador();

            var azureEjemplo = new AzureEjemplo();

            var subircodigo = new ObsSubirCodigo();
            azureEjemplo.Agregar(subircodigo);

            var compilamos = new ObsCompilar();
            azureEjemplo.Agregar(compilamos);

            var compilamospruebas = new ObsPruebasunitarias();
            azureEjemplo.Agregar(compilamospruebas);

            var instalamosversion = new ObsInstaNuevaVer();
            azureEjemplo.Agregar(instalamosversion);

            var enviamoscorreonotificador = new ObjeEnviarCorreoNot();
            azureEjemplo.Agregar(enviamoscorreonotificador);
            Console.WriteLine("Agregue nombre codigo:");
            string _ccodigo =Console.ReadLine();
            Console.WriteLine("Agreque Descripción");
            string _cdescripcion = Console.ReadLine();

            azureEjemplo.LogicadeNEgocio();

            azureEjemplo.Quitar(subircodigo);
            azureEjemplo.Quitar(compilamos);
            azureEjemplo.Quitar(compilamospruebas);
            azureEjemplo.Quitar(instalamosversion);
            azureEjemplo.Quitar(enviamoscorreonotificador);

            correoNotificador.enviarnotificacion(_ccodigo, _cdescripcion);

            Console.ReadKey();
        }
    }
}
