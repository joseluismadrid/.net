using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se pide los datos
            Console.WriteLine("Nombre Completo");
           string nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu salario");
            var salario = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu edad");
           var edad = int.Parse( Console.ReadLine());

           Double subsidio = 0;

            if (salario == 908526)
            {
                Console.WriteLine("Tiene derecho a subsidio");
            }
            else if (edad < 18)
            {
                Console.WriteLine(" No tiene derecho a subsidio");
            }
            else if (edad >= 18 && edad <= 36)
            {
                subsidio = edad * 0.5;
            }
            else if (edad >= 40 && edad <= 64)
            {
                subsidio = edad * 0.7;
            }else if (edad == 64)
            {
                subsidio = edad * 0.10;
                
            }else if (edad > 64)
            {
                Console.WriteLine(" Estas en el programa adulto mayor \n");
            }
            double total = subsidio + salario;
            Console.WriteLine($"BIENVENIDO AL PROGRAMA DE SUBSIDIOS…\n{nombre}…");
            Console.WriteLine($"El valor del subsidio es: {total:C2}");
            Console.ReadKey();
        }
    }
}