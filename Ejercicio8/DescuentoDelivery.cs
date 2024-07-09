using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class DescuentoDelivery
    {
        static void Main(string[] args)
        {
            /*
            * Ejercicio de Lógica N°8.
            * 
            * Una importante cadena de delivery cuenta con una promoción por tiempo
            * limitado en la que otorga un 15% de descuento sobre el total del valor de la compra realizada. 
            * Hacer un programa para solicitar el monto total y el mismo calcule y emita por pantalla 
            * el total a cobrar con el descuento aplicado.
            *  
            */

            // Declaración de Variables:

            float montoTotal, totalACobrar;

            // Ingreso de Datos:

            Console.WriteLine("Ingrese el Monto Total de la Compra: ");
            montoTotal = float.Parse(Console.ReadLine());

            // Procesamiento de los Datos (Determinar Descuento):

            totalACobrar = montoTotal - (montoTotal * 0.15F);

            // Egreso de Información (Resultado: Monto Total a Cobrar.):

            Console.WriteLine($"El monto total, con descuento incluido, es: {totalACobrar} pesos.");

            Console.ReadKey();

        }
    }
}