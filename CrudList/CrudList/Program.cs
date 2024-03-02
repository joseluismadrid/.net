using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudList
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("-----Licorera los mas borachos--------\n");
            int opciones = 0;
            do
            {
                Console.WriteLine("\nMenú\n\n1.Agregar Licor\n2.Consultar licor\n3.Actualizar Licor\n4.Eliminar licor\n5.Listar todos los licores\n0.Salir");
                opciones = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                switch (opciones)
                {
                    case 1:
                        Licorera.InsertarLicor();
                        break;
                    case 2:
                        Licorera.consultarLicor();
                        break;
                    case 3:
                        Licorera.ActualizarrLicor();
                        break;
                    case 4:
                        Licorera.EliminarLicor();
                        break;
                    case 5:
                        Licorera.ListrLicores();
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("¡ Adios vuelva Pronto!\n");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opcion invalida\n");
                        Console.ResetColor();
                        break;

                }
            } while (opciones !=0);
        }
    }
}
