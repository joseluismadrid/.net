// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Humanizer;

Console.WriteLine("Ingresa su nombre  ");
var nombre = Console.ReadLine();

Console.WriteLine("Digita tu cargo ");
var cargo = Console.ReadLine();

Console.WriteLine(" digite su edad  ");
var edad =int.Parse(Console.ReadLine());

Console.WriteLine("Digite su eps");
var eps = Console.ReadLine();

Console.WriteLine($"Hola  mi nombre es:' {nombre}\n mi cargo es:{cargo}\n mi edad es: {edad.ToWords()}\n mi eps es {eps}");