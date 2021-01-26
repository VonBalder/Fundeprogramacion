using System;

namespace FundProgReto1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datos
            Console.Write("Ingresar la coordenada de X1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Ingresar la coordenada de Y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Ingresar la coordenada de X2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Ingresar la coordenada de Y2: ");
            double y2 = double.Parse(Console.ReadLine());

            double v = (x2 - x1);
            //Console.WriteLine("La resta de x2 - x1 es " + v);
            double i = (y2 - y1);
            //Console.WriteLine("La resta de y2 - y1 es " + i);

            // Pendiente

            double m = i / v;
            Console.WriteLine("La pendiente es " + m);

            // intercepto

            double b1 = y1 - (m * x1);
            Console.WriteLine("El intercepto utilizando y1 y x1 es " + b1);
            double b2 = y2 - (m * x2);
            Console.WriteLine("El intercepto utilizando y2 y x2 es " + b2);

            // Distancia.

            double v2 = Math.Pow(v, 2);
            Console.WriteLine("La potencia a la 2 de x2 - x1 es " + v2);
            Double i2 = Math.Pow(i, 2);
            Console.WriteLine("La potencia a la 2 de y2 - y1 es " + i2);
            double d = Math.Sqrt(v2 + i2);
            Console.WriteLine("La distancia es " + d);

            // link del video https://youtu.be/CifGsS_eXak 
        }
    }
}
