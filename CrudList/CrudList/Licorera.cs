using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudList
{
    internal class Licorera
    {
        static List<string> insumos = new List<string>();
        protected String nombre { get; set; }
        public static void InsertarLicor()
        {
            Console.WriteLine("Inserta el licor");
            String nombreLicor = Console.ReadLine();
            insumos.Add(nombreLicor);
            Console.WriteLine($"Producto: {nombreLicor}\nagregado con éxito");

        }
        public static void consultarLicor()
        {
            Console.WriteLine("Consultar el licor de los insumos ");
            String nombreLicor = Console.ReadLine();
             if (insumos.Contains(nombreLicor)){
                Console.WriteLine($"Producto: {nombreLicor}\nse encuentra agregado");
             }else
                Console.WriteLine($"Producto: {nombreLicor}\nno se encuentra agregado ");
        } 
        public static void ActualizarrLicor()
        {
            Console.WriteLine("Actualizar  licor");
            String nombreLicor = Console.ReadLine();
            if (insumos.Contains(nombreLicor))
            {
                Console.WriteLine($"Ingresa el nuevo nombre del Producto {nombreLicor}");
                String nuevoLicor = Console.ReadLine();
                insumos[insumos.IndexOf(nombreLicor)] = nuevoLicor;
                Console.WriteLine($"Nuevo Producto  {nuevoLicor}\nActualizado con exito");
            }
            else
                Console.WriteLine($"Producto: {nombreLicor}\nno se encuentra agregado ");
        }
        public static void EliminarLicor()
        {
            Console.WriteLine("Eliminar el licor");
            String nombreLicor = Console.ReadLine();
            if (insumos.Contains(nombreLicor))
            {
                insumos.Remove(nombreLicor);
                Console.WriteLine($"Producto: {nombreLicor}\nEliminado con exito");
            }
            else
                Console.WriteLine($"Producto: {nombreLicor}\nno se encuentra agregado ");
        }
        public static void ListrLicores()
        {
            Console.WriteLine("\n--- Lista de Licores ---\n");
            foreach ( var lista in insumos){
                Console.WriteLine(lista);
            }

            Console.WriteLine("------------------------");
        }
    }
}
