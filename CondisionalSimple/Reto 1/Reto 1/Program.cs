using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu edad");
            var edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Te encuentras Resistrado 1.Si / 2.No ");
            var Registro =int.Parse(Console.ReadLine());

            if (edad >= 18 && edad <=25 && Registro == 1 )
            {
                Console.WriteLine($" puede pasar, Tienes {edad} Años");
            }
            else
            {
                Console.WriteLine($" No puedes pasar, Tienes {edad} Años");
            }

        }
    }
}
