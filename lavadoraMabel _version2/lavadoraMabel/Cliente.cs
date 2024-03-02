using System;

namespace lavadoraMabel
{
    internal class Cliente
    {

        public string Nombre;
      

        public Cliente(string nombre)
        {
            Nombre = nombre;
        }

        public void ImprimirFactura(int tiempoTotal, int peso, double costoPorKilo, double iva, double gananciaPropietario, double costoKwh)
        {
            DateTime fecha = DateTime.Now;
            Random random = new Random();
            double numeroAleatorio = random.NextDouble();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"                     Factura de cobro NR° {numeroAleatorio}");
            Console.WriteLine($"                                Fecha:  {fecha}");
            Console.WriteLine();
            Console.WriteLine($"Nombre Completo {Nombre} ");
            Console.WriteLine($"Tiempo total de lavado: {tiempoTotal} segundos");
            Console.WriteLine($"Costo total sin IVA: ${setCalcularCostoTotal(peso, costoPorKilo)}");            
            Console.WriteLine($"Costo total con IVA: ${setCalcularCostoTotalConIVA(peso, costoPorKilo, iva)}");
            Console.WriteLine("desea ver las ganacias ");
            string ganancias = Console.ReadLine();

            if (ganancias == "s" || ganancias == "S")
            {
                Console.WriteLine($"Ganancia del propietario: ${setCalcularGanancia(peso, costoPorKilo, gananciaPropietario)}");


            }

            Console.WriteLine($"Cantidad de kWh consumida: {CalcularConsumoKwh(tiempoTotal)} kWh");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine($"Presione Q o cualquier tecla  para continuar");
                Console.ReadKey();
           
          
            

        }

        private double setCalcularCostoTotal(int peso, double costoPorKilo)
        {
            return peso * costoPorKilo;
        }

        private double setCalcularCostoTotalConIVA(int peso, double costoPorKilo, double iva)
        {
            return setCalcularCostoTotal(peso, costoPorKilo) * (1 + iva);
        }

        private double setCalcularGanancia(int peso, double costoPorKilo, double gananciaPropietario)
        {
            return setCalcularCostoTotal(peso, costoPorKilo) * gananciaPropietario;
        }

        private double CalcularConsumoKwh(int tiempoTotal)
        {
            // Suponiendo una tasa de consumo fija para simplificar
            return tiempoTotal * 0.001;
        }

    }
}
