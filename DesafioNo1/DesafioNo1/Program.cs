//Desafio numero 1 
using System;

namespace desafios
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Por Favor Ingresar un Numero Entero Positivo:");
            Console.WriteLine("       ------------------- ");

            n1 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
