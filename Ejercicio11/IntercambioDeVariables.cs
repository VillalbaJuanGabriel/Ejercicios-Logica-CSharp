using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class IntercambioDeVariables
    {
        static void Main(string[] args)
        {
          /*
           * Ejercicio de Lógica N°11.
           * 
           * Realizar un algoritmo que permite intercambiar el valor de dos variables.
           * Por ejemplo, si una variable vale 5 y la otra variable vale 12, 
           * hacer que la primer variable valga 12 y la segunda valga 5.
           * Tener en cuenta que al asignar un valor a una variable, se sobreescribe el valor anterior.
           *  
           */

            // Declaración de Variables:

            int num1, num2, aux;

            // Asignación de Valores:

            num1 = 5;
            num2 = 12;

            // Muestra de los Valores Iniciales:

            Console.WriteLine(num1);
            Console.WriteLine(num2);

            // Asignación de una Variable Auxiliar donde se albergará el valor de una de las Variables anteriores. 

            aux = num1;

            // Reasignación de las Variables:

            num1 = num2;
            num2 = aux;

            // Muestra de los Valores Sobreescritos:

            Console.WriteLine(num1);
            Console.WriteLine(num2);

            Console.ReadKey();

        }
    }
}