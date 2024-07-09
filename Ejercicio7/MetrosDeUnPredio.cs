using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class MetrosDeUnPredio
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio de Lógica N°7.
             * 
             * Hacer un programa para ingresar por teclado los metros cuadrados totales de
             * un predio y los metros cuadrados cubiertos; luego calcular y mostrar por
             * pantalla el porcentaje de metros cuadrados cubiertos y el porcentaje de
             * metros cuadrados descubiertos.
             *  
             */

            // Declaración de Variables:

            float metrosTotales, metrosCubiertos, metrosDescubiertos, porcentajeCubiertos, porcentajeDescubiertos;

            // Ingreso de Datos:

            Console.WriteLine("Ingrese los Metros Cuadrados Totales del predio: ");
            metrosTotales = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los Metros Cuadrados Cubiertos del predio: ");
            metrosCubiertos = float.Parse(Console.ReadLine());

            // Calculo para Determinar los Metros Cuadrados Descubiertos:

            metrosDescubiertos = metrosTotales - metrosCubiertos;

            // Procesamiento de los Datos (Porcentajes de los Metros Cubiertos y Descubiertos):

            porcentajeCubiertos = metrosCubiertos * 100 / metrosTotales;
            porcentajeDescubiertos = metrosDescubiertos * 100 / metrosTotales;

            // Egreso de Información (Resultado de los Porcentajes Correspondientes):

            Console.WriteLine($"Porcentaje Cubiertos: {porcentajeCubiertos}%.");
            Console.WriteLine($"Porcentaje Descubiertos: {porcentajeDescubiertos}%.");

            Console.ReadKey();

        }
    }
}