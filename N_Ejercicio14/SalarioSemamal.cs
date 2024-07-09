using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Ejercicio14
{
    internal class SalarioSemamal
    {
        static void Main(string[] args)
        {
           /*
            * Ejercicio de Lógica N°14.
            * 
            * Calcular el Salario Semanal de un Trabajador dado su Salario Diario 
            * y la cantidad de días trabajados en la Semana.
            *  
            */

            // Declaración de Variables:

            float salarioDiario, salarioSemanal;
            int cantidadDias;

            // Ingreso de Datos:

            Console.WriteLine("Ingrese el Salario Diario: ");
            salarioDiario = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Cantidad de Dias Trabajados: ");
            cantidadDias = int.Parse(Console.ReadLine());

            // Procesamiento de los Datos (Calculo del Salario Semanal):

            salarioSemanal = salarioDiario * cantidadDias;

            // Egreso de Información (Resultado del Salario Semanal):

            Console.WriteLine($"El Salario Semanal del Trabajador es: {salarioSemanal} pesos.");

            Console.ReadKey();

        }
    }
}