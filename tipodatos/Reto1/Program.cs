Console.WriteLine("Venta1");
var venta1 = double.Parse(Console.ReadLine());

Console.WriteLine("Venta 2");
var venta2 = double.Parse(Console.ReadLine());

DateTime fecha = DateTime.Now;

double suma = venta1 +venta2;

double promedioBajo = Math.Floor(suma / 2);
double promedioEncima =Math.Ceiling  (venta1 + venta2 / 2);


double mayor = Math.Max (venta1,venta2);
double menor = Math.Min (venta1,venta2);

double iva = suma * 0.16;
double sinIva = suma -iva;
double total = suma + iva;

Console.WriteLine("------Tienda don jacito---------");
Console.WriteLine("");
Console.WriteLine($"------{fecha}-----");
Console.WriteLine("");
Console.WriteLine($"Promedio por debajo {promedioBajo:c2}\nPromedio por encima {promedioEncima:c2}");
Console.WriteLine("");
Console.WriteLine($"Valor Mayor {mayor}\nvalor Menor {menor}");
Console.WriteLine("");
Console.WriteLine($"Valor neto {sinIva:c2}");
Console.WriteLine($"Iva 16% {iva:c2}");
Console.WriteLine($"venta de las ciudades fue de: {total:c2}");

