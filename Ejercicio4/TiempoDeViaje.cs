using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class TiempoDeViaje
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio de Lógica N°4.
             * 
             * Hacer un programa que permita ingresar los kilómetros existentes entre dos 
             * ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla
             * el tiempo aproximado que demandará llegar de un punto a otro teniendo en
             * cuenta los datos ingresados.
             *  
             */

            // Declaración de Variables:

            float kilometros, velocidad, tiempoAprox;

            // Ingreso de Datos:

            Console.WriteLine("Ingrese la cantidad de Kilometros existentes: ");
            kilometros = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Velocidad de su vehículo, expresado en KM/h: ");
            velocidad = float.Parse(Console.ReadLine());

            // Procesamiento de los Datos (Determinar el Tiempo Aproximado del Viaje):

            tiempoAprox = kilometros / velocidad;

            // Egreso de Información (Resultado del Tiempo del Viaje):

            Console.WriteLine($"El tiempo aproximado del viaje es: {tiempoAprox.ToString("0.00")}hs.");

            Console.ReadKey();

        }
    }
}