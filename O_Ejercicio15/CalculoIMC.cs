using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Ejercicio15
{
    internal class CalculoIMC
    {
        static void Main(string[] args)
        {
           /*
            * Ejercicio de Lógica N°15.
            * 
            * Se necesita un algoritmo que calcule el Indice de Masa Corporal (IMC) de una persona 
            * a partir de brindar por teclado su peso en KG y su estatura en metros. 
            * El resultado del calculo debe ser visualizado por Consola.
            *  
            */

            // Declaración de Variables:

            float peso, estatura, resultadoIMC;

            // Ingreso de Datos:

            Console.WriteLine("Ingrese su Peso expresado en KG: ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su Estatura expresada en Metros: ");
            estatura = float.Parse(Console.ReadLine());

            // Procesamiento de los Datos (Calculo del IMC):

            resultadoIMC = peso / (estatura * estatura);

            // Egreso de Información (Resultado del IMC):

            Console.WriteLine($"Su Índice de Masa Corporal es: {resultadoIMC}.");

            Console.ReadKey();

        }
    }
}