double suma = 0;
 Console.WriteLine("");
 Console.WriteLine($"Ingresa las notas Solo debe de ser maximo 5 \n");
for (int nota = 1; nota <=3; nota++) // Bucle  for lo usamos par recorer la cantidad de notas a ingresar
{
    Console.WriteLine($"Ingresa la nota Numero {nota}"); // pide las notas  
    var notas = double.Parse(Console.ReadLine());

    if (notas <= 5) // verificamos que no sea mayor que 5 las notas ingresadas
    {
        suma += notas; // se almacenan y se suman 
    }
    else
    {
        Console.WriteLine("Las notas deben de ser entre 0 y 5");// en caso que la nota se ingrese  sea mayor muestra mensaje y detiene el programa
        return;
        
    }
};
double Promedio = Math.Round(suma / 3, 2); // se guarda la suma luego se realiza el promedio 
Console.WriteLine($"El Promedio es: {Promedio}");

if (Promedio > 3.5) // se verifica si el promedio meayor que 3.5
{
    Console.ForegroundColor = ConsoleColor.Green; // se modifica el color del texto 
    Console.WriteLine("¡Aprobaste!"); // imprimimoe el texto modificado
}
else
{
    Console.ForegroundColor = ConsoleColor.Red; // se modifica el color del texto 
    Console.WriteLine("¡No aprobastes!"); // imprimimoe el texto modificado
};
Console.ResetColor(); // se reinicia el color para que no quede cache
