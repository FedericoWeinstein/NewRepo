using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClase1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Para llamar a mi programa:

            Ejercicios E = new Ejercicios();

            //E.DeclararVariables();
            //E.DeclararConstantes();
            E.PedirDatosDinamicos();
            E.CalcularPromedio();

            //Esta línea lo que hace es que no se cierre la consola hasta que se aprieta enter.
            Console.WriteLine("Precione Enter para salir...");
            Console.ReadLine();


        }
    }
}
