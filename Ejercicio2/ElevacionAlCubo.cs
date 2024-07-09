using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class ElevacionAlCubo
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio de Lógica N°2.
             * 
             * Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
             *  
             */

            // Declaración de Variables:

            int numero, resultadoCubo;

            // Ingreso de Datos:

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            // Procesamiento de los Datos (Elevación al Cubo):

            resultadoCubo = numero * numero * numero;

            // Egreso de Información (Resultado del Número al Cubo):

            Console.WriteLine($"El resultado del número, elevado al cubo es: {resultadoCubo}.");

            Console.ReadKey();

        }
    }
}