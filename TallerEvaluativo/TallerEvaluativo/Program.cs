using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TallerEvaluativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool registro = true;
            int atendidos = 0;
            int atendidos1 = 0;
            int suma = 0;

            while (registro)
            {
                try
                {
                    Console.WriteLine("------Gym los siameses-----\n");

                    // Solicitar información personal
                    Console.WriteLine("Ingresa Nombre Completo");
                    string nombre = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nombre))
                    {
                        Console.WriteLine("Por favor, ingresa el nombre no debe de estar vacido.");
                        continue;

                    }
                    Console.WriteLine("Ingresan Documento de identidad");
                    string documento = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(documento))
                    {
                        Console.WriteLine("Por favor, ingresa el Documeto no debe de estar vacido.");
                        continue;
                    }
                    Console.WriteLine("Ingresan la Eps");
                    string eps = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(eps))
                    {
                        Console.WriteLine("Por favor, ingresa la eps no debe de estar vacido");
                        continue;
                    }
                    Console.WriteLine("Ingresan correo electronico");
                    string correo = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(correo))
                    {
                        Console.WriteLine("Por favor, ingresa un correo  no debe de estar vacido");
                        continue;
                    }
                    Console.WriteLine("Ingresan su dirección");
                    string direccion = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(direccion))
                    {
                        Console.WriteLine("Por favor, ingresa una direccion no debe de estar vacido");
                        continue;
                    }
                    Console.WriteLine("Ingresan el telefono");
                    double telefono = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresan la fecha de nacimiento");
                    string fecha = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(fecha))
                    {
                        Console.WriteLine("Por favor, ingresa una fecha no debe de estar vacido");
                        continue;
                    }
                   
                    Console.WriteLine("Ingresa tu edad");
                    int edad = Convert.ToInt32(Console.ReadLine());
                    
                    if (edad < 15)
                    {
                        Console.WriteLine("La persona aún no puede ingresar");
                        atendidos1++;
                        continue;

                    }
                    else
                    {


                        Console.WriteLine("Nivel de escolaridad");
                        string escolaridad = Console.ReadLine();
                        Console.WriteLine("Tiene alguna comorbilidad SI / NO");
                        string comorbilidad = Console.ReadLine();
                        Console.WriteLine("Ingresa tu peso");
                        double peso = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa tu estatura");
                        double estatura = double.Parse(Console.ReadLine());
                        if (string.IsNullOrWhiteSpace(escolaridad))
                        {
                            Console.WriteLine("Por favor, ingresa tu escolarida no debe de estar vacido");
                            continue;
                        }
                        else if (string.IsNullOrWhiteSpace(comorbilidad))
                        {
                            Console.WriteLine("Por favor, ingresa una comorbidad no debe de estar vacido");
                            continue;
                        }
                       
                        atendidos++;
                        // Método de pago
                        Console.WriteLine("\nMetodos de pagos  Contado / targeta de credito");
                        string pagos = Console.ReadLine();
                        // Calcular mensualidad
                        double mensualidad = 70000;
                        if (pagos.Equals("contado", StringComparison.OrdinalIgnoreCase))
                        {
                            double descuento = mensualidad * 0.16;
                            double totalAPagar = mensualidad - descuento;
                            Console.WriteLine($"Total a pagar {totalAPagar:C2}");
                        }
                        else
                        {
                            Console.WriteLine($"Total a pagar {mensualidad:C2}");
                        }
                        // Imprimir datos del registro
                        Console.WriteLine("\nInformación de Registro");
                        Console.WriteLine($"Fecha del registro: {DateTime.Now}");
                        // Calcular IMC
                        double indiceMasaCorporal = Math.Round(peso / Math.Pow(estatura, 2), 2);
                        Console.WriteLine("\nCalculo del IMC ");
                        Console.WriteLine($"Tu IMC es: {indiceMasaCorporal}\n");
                        // se valida su comorbilidad si posee alguna 
                        if (comorbilidad.Equals("SI", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Te vamos asignar un entrenador");
                        }

                        // Verificar diagnóstico según IMC
                        if (indiceMasaCorporal >= 0 && indiceMasaCorporal < 16)
                        {
                            Console.WriteLine(" Diagnostico Delgadez severa");
                            Console.WriteLine("Su peso es demaciado bajo - Consulta su medico");
                        }
                        else if (indiceMasaCorporal > 16.00 && indiceMasaCorporal < 16.99)
                        {
                            Console.Write("Diagnostico Delgadez Moderada");
                            Console.Write("Su peso es bajo -incluya calorias y carbohidratos en su dieta");
                        }
                        else if (indiceMasaCorporal > 17.00 && indiceMasaCorporal < 18.49)
                        {
                            Console.Write("Diagnostico Delgadez Leve");
                            Console.WriteLine("Su peso es ligeramente  bajo -Mejora sus habitos alimenticios");
                        }
                        else if (indiceMasaCorporal > 18.50 && indiceMasaCorporal < 24.99)
                        {
                            Console.WriteLine("Diagnostico normal");
                            Console.WriteLine("Su peso es bajo -Usted tiene un peso saludable");
                        }
                        else if (indiceMasaCorporal > 25.00 && indiceMasaCorporal < 29.99)
                        {
                            Console.WriteLine("Diagnostico PreObeso");
                            Console.WriteLine("Su peso es levemete alto -Procure hacer ejercicio");
                        }
                        else if (indiceMasaCorporal > 30.00 && indiceMasaCorporal < 34.99)
                        {
                            Console.WriteLine("Diagnostico Obesidad leve");
                            Console.WriteLine("Su peso es alto - Controle su dieta y realice ejercicio");
                        }
                        else if (indiceMasaCorporal > 35.00 && indiceMasaCorporal < 39.99)
                        {
                            Console.WriteLine( "Diagnostico Obesida Media");
                            Console.WriteLine("Su peso es muy alto - Visite a su medico y controle su dieta");
                        }
                        else if (indiceMasaCorporal >= 40.00)
                        {
                            Console.WriteLine("Obesidad  Morbidad");
                            Console.WriteLine("Su peso es bajo -incluya calorias y carbohidratos en su dieta");
                        }
                        suma = atendidos + atendidos1;
                        // imprimir datos 
                        Console.WriteLine("");                        
                        Console.WriteLine($"Nombre Completos: {nombre}");
                        Console.WriteLine($"Documento de identidad: {documento}");
                        Console.WriteLine($"EPS: {eps}");
                        Console.WriteLine($"Correo Electronico: {correo}");
                        Console.WriteLine($"Dirección Residencia: {direccion}");
                        Console.WriteLine($"Telefono: {telefono}");
                        Console.WriteLine($"Fecha nacimiento: {fecha}");
                        Console.WriteLine($"Edad: {edad}");
                        Console.WriteLine($"Nivel de escolaridad: {escolaridad}");
                        Console.WriteLine($"Comorbilidad: {comorbilidad}");
                        Console.WriteLine($"Peso: {peso}");
                        Console.WriteLine($"Estatura: {estatura}");
                        Console.WriteLine("Los Datos fueron ingresados correctamente");
                        // Preguntar si se ingresará un nuevo miembro
                        Console.WriteLine("\nDesea ingresar otro miembro al gimnasio\n1.Si\n2.NO?");
                        int ingreso = int.Parse(Console.ReadLine());

                        // Verificar si desea continuar ingresando con el while que posee el booleano
                        switch (ingreso)
                        {
                            case 1:
                                registro = true;
                                break;
                            case 2:
                                Console.WriteLine($"Miembros registrados durante la jornada: {suma}");
                                registro = false;
                                break;
                            default:
                                Console.WriteLine("Ingrese opciones válidas");
                                break;
                        }
                    }
                }

                // Validar con excepciones los datos ingresados
                catch (FormatException e)
                {
                    Console.WriteLine("Error de formato: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}
