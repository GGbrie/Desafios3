//Desafio Numero 5 

using CajaDesafios;
using System;

namespace desafios
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Empezamos agregando valores
            List<VolumenCaja> cajas1 = new List<VolumenCaja>();
            int CajasTotales = 0;
            double VolumenCaja = 0;

            //Debemos de saber cuales seran o cuantas cajas el usuario ingresara
            Console.Write("----- Cuantas cajas Ingresaras?  : ");
            CajasTotales = int.Parse(Console.ReadLine());

            //Para este paso el usuario ingresara las medidas de cada caja que ingreso 
            for (int i = 0; i < CajasTotales; i++)

            {
                //El usuario ingresara sus datos 
                VolumenCaja caja2 = new VolumenCaja();

                Console.Write("- Cual es su alto? " + (i + 1) + ": ");
                caja2.AltoV = double.Parse(Console.ReadLine());

                Console.Write("- Cual es su ancho? " + (i + 1) + ": ");
                caja2.AnchoV = double.Parse(Console.ReadLine());

                Console.Write("- Cual es su algo? " + (i + 1) + ": ");
                caja2.LargoV = double.Parse(Console.ReadLine());           

                cajas1.Add(caja2);
            }

            //Procedemos con calcular las diferentes medidas en volumen de la caja
            foreach (VolumenCaja caja3 in cajas1)
            {
                VolumenCaja += caja3.CalcularVolumen();
            }

            //Luego calculamos su promedio
            double volumenPromedio = VolumenCaja / CajasTotales;

            // Y teminamos colocando el resultado del volumen y el promerio de la caja
            Console.Write(" ----------------------- ");
            Console.WriteLine("El Volumen total es de : " + VolumenCaja);
            Console.Write(" ----------------------- ");
            Console.WriteLine("El Promedio Obtenido es de: " + volumenPromedio);
        }

    }
}