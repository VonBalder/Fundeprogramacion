using System;

namespace Reto1Semana4
{
    class Program
    {

        //video Youtube https://youtu.be/9wn-wdazu4s
        static void Main(string[] args)
        {
            double total = 0;
            string Nombre, NombreMayor = null, NombreMenor = null;
            int i = 0, max = 0, min = 200;

            Console.Write("Ingrese el número de datos (n): ");
            int n = int.Parse(Console.ReadLine());

            while (i < n)
            {
                Console.WriteLine("Ingresa tu nombre ");
                Nombre = Console.ReadLine();

                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad > max)
                {
                    max = edad;
                    NombreMayor = Nombre;
                }
                if (edad < min)
                {
                    min = edad;
                    NombreMenor = Nombre;
                };

                total += edad;
                i++;

            }
            double promedio = total / n;
            Console.WriteLine("Promedio = " + promedio);
            Console.WriteLine("Mayor = " + max);
            Console.WriteLine("Usuario de Mayor edad " + NombreMayor);
            Console.WriteLine("Menor = " + min);
            Console.WriteLine("Usuario de Menor edad " + NombreMenor);
        }
    }
}
