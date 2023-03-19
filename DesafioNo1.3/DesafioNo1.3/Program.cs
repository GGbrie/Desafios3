//Desafio Numero 4 

using desafios;
using System;

namespace desafios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlturasRectangulos Resultado = new AlturasRectangulos(4, 5);

            Console.WriteLine(Resultado.Largo + " x " + Resultado.Alto);
            Console.WriteLine(" ------------------- ");
            Console.WriteLine("La Superficie Frontal sera de : " + Resultado.SuperficieFrontal);
        }
    }
}