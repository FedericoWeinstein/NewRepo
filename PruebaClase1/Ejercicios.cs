using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClase1
{
    public class Ejercicios
    {
        public void DeclararVariables()

        {
            //Lo primero que hago es declarar las variables que voy a utilizar
            //Primero asigno el tipo de dato a utilizar y luego el nombre

            string Nombre;
            string Apellido;
            byte Edad;

            //Aca asigno valores
            // Nombre de la variable + "=" + valor

            Nombre = "Federico";
            Apellido = "Weinstein";
            Edad = 23;

            //Para mostrar los valores:

            Console.WriteLine("Su nombre es " + Nombre + " , su apellido es " + Apellido + " y tiene " + Edad + " anos.");

        }

        public void DeclararConstantes()

            //Las constantes se decaran mediante el prefijo "const" luego el tipo de dato, nombre de las constante y por último,
            //Se le debe asignar el valor a dicha constante:

        {
            const int Numero1 = 10;
            const string Nombre2 = "Pablo";

            Console.WriteLine("El valor de la constante #1 es " + Numero1 + " y el valor de la constante #2 es " + Nombre2 + ".");

        }

        //Para pedir los datos de manera dinámica

        public void PedirDatosDinamicos()
        {
            //Declaro las variables

            string Nombre;
            string Apellido;
            byte Edad;

            //Para pedir los datos
            //Primero debo pedirle al usuario que escriba para poder leerlo.

            Console.Write("Por favor ingrese su nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Por favor ingrese su apellido: ");
            Apellido = Console.ReadLine();

            //Como la variable "Edad" es un byte, debo convertír el string a un byte.

            Console.Write("Por favor ingrese su edad: ");
            Edad = Convert.ToByte(Console.ReadLine());

            //Para mostrar los valores:

            Console.WriteLine("Su nombre es " + Nombre + " , su apellido es " + Apellido + " y tiene " + Edad + " anos.");

        }

        public void CalcularPromedio()

        {
            //Declaro las variables

            float Teorico1;
            float Teorico2;
            float Practico1;
            float Practico2;
            float Promedio;

            Console.Write("Por favor ingrese la nota del Teorico #1: ");
            Teorico1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Por favor ingrese la nota del Teorico #2: ");
            Teorico2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Por favor ingrese la nota del Practico #1: ");
            Practico1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Por favor ingrese la nota del Practico #2: ");
            Practico2 = Convert.ToSingle(Console.ReadLine());

            Promedio = (Teorico1 + Teorico2 + Practico1 + Practico2) / 4;

            Console.WriteLine("Su Promedio es: " + Promedio);


        }
    }
}
