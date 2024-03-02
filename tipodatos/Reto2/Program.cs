Console.WriteLine("Numero de empleado a pagar");
var Empleados = int.Parse(Console.ReadLine());
for (int i = 0; i < Empleados; i++)
{
  Console.WriteLine("");
  Console.WriteLine("Nombre del Empleado");
  var Nombre= Console.ReadLine();
  Console.WriteLine("Ingresa el Valor a Pagar");
  var pagoEmpleados = double.Parse(Console.ReadLine()+"\n");  //Pregunto  el salario del empleado
  Console.WriteLine("El Valor del dolar");
  var Dolar = double.Parse(Console.ReadLine()+"\n"); // Pregunto por el valor del dolar actual 
  Console.WriteLine("El Valor del Euro");
  var Euro = double.Parse(Console.ReadLine()+"\n");
  double valorDolar = Math.Round(pagoEmpleados / Dolar,2);// Pregunto por el valor Del Dolar Actual
  double valorEuro = Math.Round(pagoEmpleados / Euro,2); // Pregunto por el valor Del euro Actual
  DateTime fecha = DateTime.Now;
  // se Imprime el valor por cada moneda
  Console.WriteLine($"Fecha De la Transacción: {fecha}\nNombre del Empleado es: {Nombre}\nValor apagar en Peso colombiano es: {pagoEmpleados:C2}\nValor equivalente en dolares es: {valorDolar:c2}\nValor equivalente en euros es: {valorEuro:c2}\n");
  
}



