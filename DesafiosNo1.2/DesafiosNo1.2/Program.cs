//Desafio Numero 3 ---- Promedios 
using System;

namespace desafios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Empezamos con definir las variables que vamos a utilizar 
            int valoracion = 0;
            int sumvaloracion = 0;
            int contvaloracion = 0;
            double promediototal = 0.0;
            string entradaval = "";

            //Aqui le diremos que necesitamos que haga para escribir las notas de los alumnos 
            Console.WriteLine("Ingrese la nota del alumno, permitido del (1 a 10):");
            Console.WriteLine("       --------------------------- ");
            Console.WriteLine("Escribe la palabra Fin para calcular su promedio");

            //Primer ciclo para obtener las notas  
            do
            {
                //El usuario escribira la nota del alumno  
                entradaval = Console.ReadLine();

                //Si el usuario que es el maestro ingresa una nota la guardaremos 
                if (int.TryParse(entradaval, out valoracion))
                {
                    //Verificamos los parametros establecidos, que estan del 1 al 10 
                    if (valoracion >= 1 && valoracion <= 10)
                    {
                        //La calificacion de agregara 
                        sumvaloracion += valoracion;

                        //Aqui aumentaremos el contador 
                        contvaloracion++;
                    }
                    else
                    {
                        //Le diremos que la nota que ingreso no esta en nuestros parametros y volvera a intentarlo.
                        Console.WriteLine("la nota no esta entre 1 y 10, inténtalo de nuevo.");
                    }
                }
            } while (entradaval != "Fin");

            //Ingresando calificaciones de los alumnos 
            if (contvaloracion > 0)
            {
                //Se obtendra el promedio de las notas 
                promediototal = (double)sumvaloracion / contvaloracion;

                //Aparecera en pantalla el premedio obtenido 
                Console.WriteLine("El Puntaje Promedio Obtenido es: {0}", promediototal);

                //El usuario termina el proceso de notas 
                Console.ReadKey();
            }
        }
    }
}
