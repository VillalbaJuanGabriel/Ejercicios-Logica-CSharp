using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class PorcentajeEstudiantes
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio de Lógica N°9.
             * 
             * Una universidad desea conocer los porcentajes de mujeres y hombres en las
             * carreras de ciencias exactas. Se solicita un programa para cargar la cantidad de
             * mujeres y la cantidad de hombres y que el mismo calcule y emita por pantalla
             * los porcentajes correspondientes.
             *  
             */

            // Declaración de Variables:

            float mujeres, hombres, estudiantes, porcentajeMujeres, porcentajeHombres;

            // Ingreso de Datos:

            Console.WriteLine("Ingrese la Cantidad de Mujeres: ");
            mujeres = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Cantidad de Hombres: ");
            hombres = float.Parse(Console.ReadLine());

            // Calculo para Determinar la Cantidad de Estudiantes:

            estudiantes = mujeres + hombres;

            // Procesamiento de los Datos (Porcentajes de Mujeres y Hombres):

            porcentajeMujeres = mujeres * 100 / estudiantes;
            porcentajeHombres = hombres * 100 / estudiantes;

            // Egreso de Información (Resultado de los Porcentajes Correspondientes):

            Console.WriteLine($"Porcentaje Mujeres: {porcentajeMujeres}%.");
            Console.WriteLine($"Porcentaje Hombres: {porcentajeHombres}%.");

            Console.ReadKey();

        }
    }
}