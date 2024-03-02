using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Formateo_de_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Colocar signo de pesos y separado");
            double precioVenta = 100767.89;

            Console.WriteLine($"El precio de venta es {precioVenta:C}");// La c se usa para todo referente a la divisa  lo separa por  puntos y comas y el signo se lo coloca al final
            Console.ReadKey();
            Console.WriteLine("");

            //  formateo de porcentaje
            Console.WriteLine("Formateo Porcentaje Usando ToString");
            double porcentaje = 0.15;
            string porcentajeFormateado = porcentaje.ToString("P");
            Console.WriteLine("El porcentaje de 0.15 es :" + porcentajeFormateado);
            Console.WriteLine("");
            Console.WriteLine("Preciona una tecla  para continuar");
            Console.ReadKey();

            Console.WriteLine("Mostrar dos decimales");
            int numero = 1234567;
            string numeroFormatiado1 = numero.ToString("N");
            string numeroFormatiado2 = numero.ToString("N2");
            string numeroFormatiado3 = numero.ToString("D8");
            string numeroFormatiado4 = string.Format("{0:C}", numero);
            Console.WriteLine("Salida formato 1 " + numeroFormatiado1);
            Console.WriteLine("Salida formato 2 " + numeroFormatiado2);
            Console.WriteLine("Salida formato 3 " + numeroFormatiado3);
            Console.WriteLine("Salida formato 4 " + numeroFormatiado4);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Preciona una tecla  para continuar");
            Console.ReadKey();

            Console.WriteLine("Esto tardara 8 segundos en ejecutar");
            Thread.Sleep(8000);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Preciona una tecla  para continuar");
            Console.ReadKey();

            Console.WriteLine("Formateo de cadena");
            string nombre = "juan";
            int edad = 30;
            string formateoCadena1 = string.Format("Mi nombre es {0} y tengo {1} años",nombre,edad);
            string formateoCadena2 = ($"Mi nombre es {nombre} y tengo {edad} años");
            string formateoCadena3 = string.Format("El numero es: {0, -10}",42);
            string formateoCadena4 = string.Format("El numero es: {0, 10}", 42);
            Console.WriteLine(formateoCadena1);
            Console.WriteLine(formateoCadena2);
            Console.WriteLine(formateoCadena3);
            Console.WriteLine(formateoCadena4);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Preciona una tecla  para continuar");
            Console.ReadKey();

            // Formateo de fecha y hora
            Console.WriteLine("Formateo de Fecha y hora:");
            DateTime fechaHoraActual = DateTime.Now;
            string formatoFecha1 = fechaHoraActual.ToString("d"); //
            string formatoFecha2 = fechaHoraActual.ToString("D"); //
            string formatoHora = fechaHoraActual.ToString("T"); //
            Console.WriteLine("Formato d fecha 1 " + formatoFecha1);
            Console.WriteLine("Formato d fecha 2 " + formatoFecha2);
            Console.WriteLine("Formato hora " + formatoHora); //
            Console.WriteLine("------------------------------------------------------ ");
            Console.WriteLine("Presiona una tecla para continuar..");
            Console.ReadKey();
            Console.WriteLine("Formateo de valores booleanos:");
            bool esVerdadero = true;
            string valorBooleano1 = esVerdadero.ToString(); //
            string valorBooleano2 = esVerdadero.ToString().ToUpper(); //
            string valorBooleano3 = esVerdadero ? "Sí" : "No"; //
            Console.WriteLine(valorBooleano1); //
            Console.WriteLine(valorBooleano2); //
            Console.WriteLine(valorBooleano3); //
            Console.WriteLine("------------------------------------------------------ ");
            Console.WriteLine("Presiona una tecla para continuar..");
            Console.ReadKey();

            //Cambiar el color del texto usando Console.ForegroundColor:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Color Azul");
            Console.ResetColor();//resetear Color
            Console.WriteLine("Texto normal");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Fondo amarillo");
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
            //Limpiar la consola
            Console.WriteLine("Limpiando La consola");
            Console.Clear();

        }
    }
}
