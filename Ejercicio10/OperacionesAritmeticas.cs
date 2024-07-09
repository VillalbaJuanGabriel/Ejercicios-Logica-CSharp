using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class OperacionesAritmeticas
    {
        static void Main(string[] args)
        {
            /*
            * Ejercicio de Lógica N°10.
            * 
            * Hacer un programa que permita ingresar por teclado dos números y que luego
            * muestre por pantalla la suma, la resta, la multiplicación y la división de dichos números. 
            * Se deben mostrar cuatro resultados en pantalla. 
            * Los números deben ser solicitados una única vez.
            *  
            */

            // Declaración de Variables:

            int num1, num2, suma, resta, multiplicacion, division;

            // Ingreso de Datos:

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num2 = int.Parse(Console.ReadLine());

            // Procesamiento de los Datos (Suma, Resta, Multiplicación y División):

            suma = num1 + num2;
            resta = num1 - num2;
            multiplicacion = num1 * num2;
            division = num1 / num2;

            // Egreso de Información (Resultados de las Operaciones Aritméticas):

            Console.WriteLine($"Los Resultados de las Operaciones Aritméticas son: ");
            Console.WriteLine($"Suma: {suma}.");
            Console.WriteLine($"Resta: {resta}.");
            Console.WriteLine($"Multiplicación: {multiplicacion}.");
            Console.WriteLine($"División: {division}.");

            Console.ReadKey();

        }
    }
}