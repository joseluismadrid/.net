using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversidadReto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicito de datos 
            Console.WriteLine("A cuauntos kilometros vive de la universidad");          
            var distancia = double.Parse(Console.ReadLine());
            Console.WriteLine("Cual es el valor de tus ingresos familiares");
            var ingresos = double.Parse(Console.ReadLine());
           Console.WriteLine("Cual es tu estracto social");
            var estracto = double.Parse(Console.ReadLine());
            // se inicializan datos 
            Double beca = 0;
            double salarioMinimo = 1462000;
            // Validacion de datos 
            if (distancia <= 5 && ingresos <= 600000 && estracto >=1 && estracto <= 2)
            {
                beca = 0.44 * salarioMinimo;
            }
            else
            {
                Console.WriteLine("No Obtienes tienes Beca\n");
            }
            // se imprime mensaje
            Console.WriteLine($"Tu beca es de {beca:C}");
            Console.ReadKey();

        }
    }
}
