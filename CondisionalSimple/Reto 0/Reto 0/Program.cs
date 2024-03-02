using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionalRetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se le solicita al Usuario Informacion
            Console.WriteLine("Nombre del empleado");
            var empleado = Console.ReadLine();
            Console.WriteLine("Ingresa el Sueldo");
            var sueldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero de Hijos");
            var numeroHijos = int.Parse(Console.ReadLine());
            // se inicializa variable en cero pra realizar operaciones
            double bono = 0;
            // validacion  de la informacion suministrada
            if (numeroHijos == 0 && sueldo <= 1160000) 
            {
                bono = 0;
            } 
            else if (numeroHijos >= 1 && numeroHijos <= 3 && sueldo >= 1160000 && sueldo <= 2320000)
            {

                bono = 0.10 * sueldo ;
            }
            else if (numeroHijos >= 3 && numeroHijos >= 5 && sueldo <= 1160000)
            {
                bono = 0.25 * sueldo;
            }
            else
            {
                Console.WriteLine("No tiene  bono el empleado");
            }
            
            // Se calcuna el sueldo +mas el bono a dar 
            double total = sueldo + bono;
            // se imprime los resultados
            Console.WriteLine($" El empleado {empleado} tiene uno sueldo de {sueldo:C2} tiene {numeroHijos} hijos y su sueldo con bono es {total:C2}");
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();


        }
    }
}
