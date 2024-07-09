using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_Ejercicio12
{
    internal class Saludo
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio de Lógica N°12.
             * 
             * Solicitar al Usuario que ingrese su Nombre y su Edad y mostrar por Consola 
             * un saludo que incluya esta información.
             *  
             */

            // Declaración de Variables:

            string nombre, saludo; 
            int edad;

            // Ingreso de Datos:

            Console.WriteLine("Ingrese su Nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su Edad: ");
            edad = int.Parse(Console.ReadLine());

            // Procesamiento de los Datos (Escritura del Saludo):

            saludo = $"Buenas Tardes {nombre}! ¿Tienes {edad} años? Bienvenido!";

            // Egreso de Información (Resultado: Saludo.):

            Console.WriteLine(saludo);

            Console.ReadKey();

        }
    }
}