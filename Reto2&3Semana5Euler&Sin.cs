using System;

namespace EulerSin
{
    class Program
    {
        public static void Main()
        {

            //profe mil disculpas no hay video, estoy muy agripado.

            // Euler
            Console.WriteLine(Euler(3, 100)); // 20.085

            // Sin
            Console.WriteLine(Sin(0.5, 100)); // 0.48
            Console.WriteLine(Sin(1.25, 100)); // 0.95
        }

        public static double Factorial(double n)
        {
            double r = 1;
            for (double i = n; i >= 1; --i)
            {
                r *= i;
            }
            return r;
        }

        public static double Euler(double x, double n)
        {
            double r = 0;
            for (int i = 0; i < n; ++i)
            {
                double first = Math.Pow(x, i);
                double f = Factorial(i);
                r += (first / f);
            }
            return r;
        }

        public static double Sin(double x, double n)
        {
            double r = 0;

            for (int i = 0; i < n; ++i)
            {

                double first = Math.Pow(-1, i);
                double sum = (2 * i) + 1;
                double second = Factorial(sum);
                double third = Math.Pow(x, sum);

                r += ((first / second) * third);
            }

            return Math.Round(r, 2);

        }
    }
}
