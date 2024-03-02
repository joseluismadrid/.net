using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
using System.Net;



namespace lavadoraMabel
{
    internal class Lavadora
    {

        protected int pesoRopa=0;
        protected List<int> listaRopa = new List<int>();
        protected string temperatura;
        protected int tiempoTotal = 0;
        protected int peso = 0;
        protected int temperaturas = 0;
        private double costoPorKilo = 4000;
        private double iva = 0.05;
        private double gananciaPropietario = 0.3;
        private double costoKwh = 516.72;
        private int clientesAtendidos = 0;





        // La Funcion para el sonido.......
        private void Sounds(string filePath)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(filePath);
                player.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al reproducir el sonido: " + ex.Message);
            }
        }

        //la funcion donde se llaman todos los metodos.....
        public void IniciarCiclo()
        {


            bool inicio = true;
            while (inicio)
            {
                try
                {



                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ingresa la opcion del tipo de ropa\n\n1.ropa de colores\n2.algodón\n3.lycra\n4.sedas\n5.Jeans\n6.tenis\n7.cobijas\n8.ropa negra\n9.ropa blanca\n10.ropa de lana\n11.sabanas\n12.toallas\n13.Ropa Sucia\n");
                    var Ropa = int.Parse(Console.ReadLine());

                    listaRopa.Add(Ropa);


                    Console.WriteLine("");
                    switch (Ropa)
                    {
                        case 1:
                            Console.WriteLine("La Prenda Ingresada es:");
                            Console.WriteLine("Ropa de Color");
                            break;
                        case 2:
                            Console.WriteLine("La Prenda Ingresada es:");
                            Console.WriteLine("algodon");
                            break;
                        case 3:
                            Console.WriteLine("La Prenda Ingresada es:");
                            Console.WriteLine("lycra");
                            break;
                        case 4:
                            Console.WriteLine("La Prenda Ingresada es:");
                            Console.WriteLine("Seda");
                            break;
                        case 5:
                            Console.WriteLine("La Prenda Ingresada es:");
                            Console.WriteLine("Jeans");
                            break;
                        case 6:
                            Console.WriteLine("La Prenda Ingresada es:");
                            Console.WriteLine("Tenis");
                            break;
                        case 7:
                            Console.WriteLine("La Prenda Ingresada es:");
                            Console.WriteLine("Cobijas");
                            break;
                        case 8:
                            Console.WriteLine("La Prenda Ingresada es:");
                            Console.WriteLine("Ropa negra");
                            break;
                        case 9:
                            Console.WriteLine("La Prenda Ingresada es:");
                            Console.WriteLine("Ropa blanca");
                            break;
                        case 10:
                            Console.WriteLine("La Prenda Ingresada es:");
                            Console.WriteLine("Ropa de lana");
                            break;
                        case 11:
                            Console.WriteLine("La Prenda Ingresada es:");
                            Console.WriteLine("Sabanas");
                            break;
                        case 12:
                            Console.WriteLine("La Prenda Ingresada es:");
                            Console.WriteLine("Toallas");
                            break;
                        case 13:
                            Console.WriteLine("La Prenda Ingresada esta:");
                            Console.WriteLine("muy sucia");
                            Console.WriteLine("Ingresa el tiempo para mejor lavado");
                            int tiempoExtra = int.Parse(Console.ReadLine());
                            tiempoTotal += tiempoExtra;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("No podemos reconocer su");
                            continue;



                           


                    }
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    if (Ropa == 1 || Ropa == 2 || Ropa == 3 || Ropa == 4)
                    {
                        Console.WriteLine("La temperatura de lavado es Fria es hasta los:");
                        Console.WriteLine("20°");
                        Console.WriteLine("se recomienda para ropa de colores, algodón, lycra, sedas, prendas delicadas y telas que puedan achicarse");
                    }
                    else if (Ropa == 5 || Ropa == 8 || Ropa == 9 || Ropa == 10 || Ropa == 6 || Ropa == 13)
                    {
                        Console.WriteLine("La temperatura de lavado es Caliente es desde los:");
                        Console.WriteLine("30 a 50º");
                        Console.WriteLine("se recomienda para jeans, camperas, ropa muy sucia o poco delicada");
                    }
                    else if (Ropa == 7 || Ropa == 11 || Ropa == 12)
                    {
                        Console.WriteLine("La temperatura de lavado es tibia  es desde los:");
                        Console.WriteLine("55 a 90º");
                        Console.WriteLine("se recomienda para toallas, sábanas o acolchados, telas blancas gruesas y cortinas de tela"); 
                    }
                    Console.ResetColor();


                    Console.WriteLine("---------------------\n");
                    Console.WriteLine("\nIngresa el peso");
                    int pesoRopa = int.Parse(Console.ReadLine());
                    Console.WriteLine("El Peso Ingresado es:" + pesoRopa + " Kilos");

                    peso += pesoRopa;
                    if (pesoRopa < 10 || pesoRopa > 30)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("El peso de la ropa debe ser minimo 10 maximo 30 kilos");
                        Console.ResetColor();
                        continue;

                    }
                    else
                    {
                        setLlenado();
                        setLavado();
                        setEnjuague();
                        setSecado();
                        SetCicloTerminado();

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            }// este es el fin del bucle while


        }
        // se incia los metodos    y sus funciones 
        private void setLlenado()
        {
            int tiempoLlenado = 7;
            tiempoTotal += tiempoLlenado;
            Console.WriteLine("\nIniciando Llenado");
            Thread soundThread = new Thread(() => Sounds("D:\\ADSO\\5°Trimestre\\.net\\lavadoraMabel _version2\\lavadoraMabel\\sonidos\\Lavadorallenado.wav"));
            soundThread.Start();

            for (int i = 0; i <= 100; i += 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"\r[llenando{new string('|', i / 10)}{new string(' ', (100 - i) / 10)}]{i}%");
                Console.ResetColor();
                Thread.Sleep(7000);
            }
            soundThread.Interrupt(); // Espera a que termine el hilo de sonido
            Console.WriteLine();
            Console.WriteLine($"El tiempo transcurido en esto ciclo es {tiempoLlenado} segundos ");



        }// esta es el final de setLLenando
        private void setLavado()
        {
            int tiempoLavado = 6;
            tiempoTotal += tiempoLavado;
            Console.WriteLine("\nIniciando Lavado");
            Thread soundThread = new Thread(() => Sounds("D:\\ADSO\\5°Trimestre\\.net\\lavadoraMabel _version2\\lavadoraMabel\\sonidos\\LavandoRopa.wav"));
            soundThread.Start();
            for (int i = 0; i <= 100; i += 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"\r[llavando{new string('|', i / 10)}{new string(' ', (100 - i) / 10)}]{i}%");
                Console.ResetColor();
                Thread.Sleep(6000);
            }
            soundThread.Interrupt();   // Espera a que termine el hilo de sonido
            Console.WriteLine();
            Console.WriteLine($"El tiempo transcurido en esto ciclo es {tiempoLavado} segundos ");


        }// esta es el final de setLavado
        private void setEnjuague()
        {
            int tiempoEnjuague = 6;
            tiempoTotal += tiempoEnjuague;
            Console.WriteLine("\nIniciando Enjuaje");
            Thread soundThread = new Thread(() => Sounds("D:\\ADSO\\5°Trimestre\\.net\\lavadoraMabel _version2\\lavadoraMabel\\sonidos\\enjuagar.wav"));
            soundThread.Start();
            for (int i = 0; i <= 100; i += 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"\r[Enjuagando{new string('|', i / 10)}{new string(' ', (100 - i) / 10)}]{i}%");
                Console.ResetColor();
                Thread.Sleep(1000);
            }
            soundThread.Interrupt(); // Espera a que termine el hilo de sonido
            Console.WriteLine();
            Console.WriteLine($"El tiempo transcurido en esto ciclo es {tiempoEnjuague} segundos ");
        }// esta es el final de setenjuage........
        private void setSecado()
        {
            int tiempoSecado = 7;
            tiempoTotal += tiempoSecado;
            Console.WriteLine("\nDesaea secar\n1.Si\n2.No");
            int secado = int.Parse(Console.ReadLine());
            switch (secado)
            {
                case 1:
                    Console.WriteLine("\nIniciando secado");
                    Thread soundThread = new Thread(() => Sounds("D:\\ADSO\\5°Trimestre\\.net\\lavadoraMabel _version2\\lavadoraMabel\\sonidos\\secado.wav"));
                    soundThread.Start();
                    
                    for (int i = 0; i <= 100; i += 10)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write($"\b\r[Secando{new string('|', i / 10)}{new string(' ', (100 - i) / 10)}]{i}%");
                        Console.ResetColor();
                        Thread.Sleep(1000);
                    }
                    soundThread.Join(); ; // Espera a que termine el hilo de sonido
                    Console.WriteLine();
                    Console.WriteLine($"El tiempo transcurido en esto ciclo es {tiempoSecado} segundos ");
                    break;
                case 2:
                    Console.WriteLine(" Quieres Reanudar  presione un tecla");
                    Console.ReadKey();
                    setSecado();
                    break;


                default:
                    Console.WriteLine("opcion invalida");
                    break;
            }


        }// esta es el final de secado........

        public void SetCicloTerminado()
        {
            
            Console.WriteLine("Desea factura s/n");
            string factura = Console.ReadLine();

            if (factura == "s" || factura == "S")
            {
                Console.WriteLine("Nombre Completo");
                string nombre = Console.ReadLine();
                Cliente cliente = new Cliente(nombre);
                cliente.ImprimirFactura(tiempoTotal, peso, costoPorKilo, iva, gananciaPropietario, costoKwh);

                clientesAtendidos++;
              
            }

            int conteoClientes=0;
            conteoClientes += clientesAtendidos;
             Console.WriteLine($"Clientes atendidos: {conteoClientes}");


        }

    }// esta es el final de la classe......


}// esta es el  namespace....