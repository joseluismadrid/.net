using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Nomina--------");
            Console.WriteLine("");
            Console.WriteLine("Nombre del empleado");
           var Nombre =Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Codigo del empleado");
            var codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Horas trabajadas");
            var horasTrabajadas = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Valor de cada hora ");
            var valorCadaHora = double.Parse(Console.ReadLine());


            Double salarioEmpleado = valorCadaHora * horasTrabajadas;
            string salarioRedondeado1 = Math.Ceiling(salarioEmpleado).ToString("P"); ;
            string salarioRedondeado2 = Math.Round(salarioEmpleado, 2).ToString("C2");



            if (  salarioEmpleado > 2600000){
                Console.WriteLine("NO recibe subsidio de transporte.");
            }
            else
            {
                Console.WriteLine(" Si recibe subsidio de transporte.");
            }
            Console.WriteLine($"Empleado {Nombre}");
            Console.WriteLine($"Codigo Empleado  {codigo}");
            Console.WriteLine($"Salario sin Formato {salarioEmpleado.ToString()}");
            Console.WriteLine($"Salario redondeado Por encima {salarioRedondeado1}");
            Console.WriteLine("");
            Console.WriteLine($"Salario redondeado Por cercano {salarioRedondeado2}");
            Console.ReadKey();

        }
    }
}
