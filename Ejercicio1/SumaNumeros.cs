using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class SumaNumeros
    {
        static void Main(string[] args)
        {
           /*
            * Ejercicio de Lógica N°1.
            * 
            * Realizar la Suma de Dos Números y Mostrar su Resultado por Consola.
            *  
            */

            // Declaración de Variables:

            int num1, num2, resultadoSuma;

            // Ingreso de Datos:

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num2 = int.Parse(Console.ReadLine());

            // Procesamiento de los Datos (Suma de los Dos Números):

            resultadoSuma = num1 + num2;

            // Egreso de Información (Resultado de la Suma de los Dos Números: ):

            Console.WriteLine($"El resultado de la suma es: {resultadoSuma}.");

            Console.ReadKey();

        }
    }
}