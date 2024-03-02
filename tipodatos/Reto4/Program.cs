// fecha y hora actual
DateTime fechaRegistro = DateTime.Now;

//Datos Iniciales.....
int numerosEmpleados=5;
int diasTrabajados=6;
int horasTrabajadas=8;
int semanaUno = 1500;
int semanaDos= 2300;

// Formula  Semana uno
var ProductividadIndividualHora = (double )semanaUno / (numerosEmpleados * diasTrabajados * horasTrabajadas);
var ProductividadIndividualDia  = (double) ProductividadIndividualHora * horasTrabajadas;
var ProductividadGrupoDía =  (double) numerosEmpleados * ProductividadIndividualHora * horasTrabajadas;

// Formula semana2
var ProductividadIndividualHora2 = (double)semanaDos / (numerosEmpleados * diasTrabajados * horasTrabajadas);
var ProductividadIndividualDia2 = (double)ProductividadIndividualHora2 * horasTrabajadas;
var ProductividadGrupoDía2 = (double)numerosEmpleados * ProductividadIndividualHora2 * horasTrabajadas;

var  variacionAbsolutaEmpleado = (double)ProductividadIndividualHora2 - ProductividadIndividualHora;
var variacionRelativaEmpleado =  (double) semanaDos/semanaUno-1;

var varacionRelativaProduccionGlobal= (double) semanaDos / semanaUno-1;
var varacionAbsolutaProduccionGlobal=  (double) semanaDos - semanaUno;

// imprimimos  semana uno
Console.WriteLine("-----------------¡Bienvenido al sistema de productividad! --------------------");
Console.WriteLine("");
Console.WriteLine($"Saludos 'Thaliana Paris', hoy es: {fechaRegistro.ToShortDateString()}");
Console.WriteLine("Semana Uno");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------------------------------------------");
Console.WriteLine($"La productividad Individual de cada empleado por hora es: {Math.Round(ProductividadIndividualHora, 2)}");
Console.WriteLine($"La productividad Individual de cada empleado por día es: {Math.Round(ProductividadIndividualDia, 2)}");
Console.WriteLine($"La productividad del grupo por día es: {Math.Round(ProductividadGrupoDía,2)}");
Console.WriteLine("----------------------------------------------------------------------------------------------");    
Console.WriteLine("");

// imprimimos  semana dos
Console.WriteLine("---------------------¡Bienvenido al sistema de productividad! --------------------");
Console.WriteLine("");
Console.WriteLine($"Saludos 'Thaliana Paris', hoy es: {fechaRegistro.ToShortDateString()}");
Console.WriteLine("Semana Dos");
Console.WriteLine("");
Console.WriteLine("----------------------------------------------------------------------------------");
Console.WriteLine($"La productividad Individual de cada empleado por hora es: {Math.Round(ProductividadIndividualHora2,2)}");
Console.WriteLine($"La productividad Individual de cada empleado por día es: {Math.Round(ProductividadIndividualDia2,2)}");
Console.WriteLine($"La productividad del grupo por día es: {Math.Round(ProductividadGrupoDía2,2)}");
Console.WriteLine($"La variación absoluta de la productividad hora hombre fue: {Math.Round(variacionAbsolutaEmpleado,2)}");
Console.WriteLine($"La variación relativa de la productividad hora hombre fue: {Math.Round(variacionRelativaEmpleado,2)}");
Console.WriteLine($"La variación relativa de la producción global fue: {Math.Round(varacionRelativaProduccionGlobal,2)}");
Console.WriteLine($"La variación absoluta de la producción global fue: {Math.Round(varacionAbsolutaProduccionGlobal,2)}");
Console.WriteLine("----------------------------------------------------------------------------------------------");    