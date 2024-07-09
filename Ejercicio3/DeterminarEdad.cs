using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class DeterminarEdad
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio de Lógica N°3.
             * 
             * Hacer un programa que permita ingresar el año actual y el año de la fecha de nacimiento 
             * de una persona y luego calcule y emita por pantalla su edad.
             *  
            */

            // Declaración de Variables:

            int añoActual, añoNacimiento, edad;

            // Ingreso de Datos:

            Console.WriteLine("Ingrese el Año Actual: ");
            añoActual = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su Año de Nacimiento: ");
            añoNacimiento = int.Parse(Console.ReadLine());

            // Procesamiento de los Datos (Determinar la Edad):

            edad = añoActual - añoNacimiento;

            // Egreso de Información (Resultado de la Edad):

            Console.WriteLine($"Tienes una edad de: {edad} años.");

            Console.ReadKey();

        }
    }
}