using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class PromedioNotas
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio de Lógica N°6.
             * 
             * Hacer un programa para ingresar por teclado las cuatro notas de exámenes de un alumno 
             * y luego calcule y emita por pantalla el promedio final.
             *  
             */

            // Declaración de Variables:

            float num1, num2, num3, num4, promedioFinal;

            // Ingreso de Datos:

            Console.WriteLine("Ingrese su primer nota: ");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su segunda nota: ");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su tercer nota: ");
            num3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su cuarta nota: ");
            num4 = float.Parse(Console.ReadLine());

            // Procesamiento de los Datos (Determinar Promedio):

            promedioFinal = (num1 + num2 + num3 + num4) / 4;

            // Egreso de Información (Resultado del Promedio Final):

            Console.WriteLine($"El promedio final del alumno es: {promedioFinal}.");

            Console.ReadKey();

        }
    }
}