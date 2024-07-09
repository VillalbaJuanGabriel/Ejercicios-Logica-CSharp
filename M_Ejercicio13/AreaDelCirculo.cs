using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_Ejercicio13
{
    internal class AreaDelCirculo
    {
        static void Main(string[] args)
        {
           /*
            * Ejercicio de Lógica N°13.
            * 
            * Calcular el Área de un Círculo dado su Radio.
            *  
            */

            // Declaración de Variables:

            float radio, area;

            // Constante PI:

            const float NUMERO_PI = 3.1416F;

            // Ingreso de Datos:

            Console.WriteLine("Ingrese el Radio del Circulo: ");
            radio = float.Parse(Console.ReadLine());

            // Procesamiento de los Datos (Determinar el Area del Circulo):

            area = radio * radio * NUMERO_PI;

            // Egreso de Información (Resultado del Area del Circulo):

            Console.WriteLine($"El Área del Circulo es: {area}.");

            Console.ReadKey();

        }
    }
}