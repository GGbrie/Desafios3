// Desafio Numero 2
using System;

namespace desafios

{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Por favor ingrese un número entero positivo");
            Console.WriteLine("          ------------------- ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 <= 1)
            {
                Console.WriteLine("El número que ha ingresado no es primo, intentelo otra vez");
                return;
            }

            bool NumPrim = true;

            for (int i = 2; i < n1; i++)
            {
                if (n1 % i == 0)
                {
                    NumPrim = false;
                    break;
                }
            }

            if (NumPrim)
            {
                Console.WriteLine("Si es un número primo");
            }
            else
            {
                Console.WriteLine("El número que ha ingresado no es primo");
            }
        }
    }
}