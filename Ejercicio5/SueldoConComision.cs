using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class SueldoConComision
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio de Lógica N°5.
             * 
             * Una casa de computación paga a sus empleados un sueldo fijo de ARS 15000
             * más una comisión del 5% sobre el total facturado por cada empleado. Hacer un
             * programa para ingresar el total facturado por un empleado y que luego calcule
             * y emita por pantalla el sueldo total a cobrar por el mismo.
             *  
             */

            // Declaración de Variables:

            float totalFacturado, sueldoTotal;

            // Declaración de Constantes con sus valores fijos:

            const float SUELDO_FIJO = 15000;
            const float COMISION = 0.05F;

            // Ingreso de Datos:

            Console.WriteLine("Ingrese el Total Facturado: ");
            totalFacturado = float.Parse(Console.ReadLine());

            // Procesamiento de los Datos (Determinar el Sueldo con La Comisión incluida):

            sueldoTotal = SUELDO_FIJO + (totalFacturado * COMISION);

            // Egreso de Información (Sueldo Total):

            Console.WriteLine($"El sueldo total del empleado, más la comisión, es: {sueldoTotal} pesos.");

            Console.ReadKey();

        }
    }
}