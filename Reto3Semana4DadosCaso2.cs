using System;

namespace Reto2Semana4DadosCaso2
{
    class Reto2Semana4DadosCaso2
    {
        static void Main(string[] args)
        {

            // Video Youtube https://youtu.be/9wn-wdazu4s
            Random aleatorio = new Random();
            int dado = 0, total = 0, turnos = 0, Diez = 0;
            String Tirar = "s";

            while (Tirar == "s" || total <= 100)
            {
                dado = aleatorio.Next(1, 13);
                turnos += 1;

                Console.WriteLine("Dado " + dado);

                if (dado == 10)
                {
                    Diez += 1;
                    if (Diez == 1 && dado == 12)
                    {
                        Console.WriteLine("Cumpliste la condicion especial (sacar 12 despues de un 10), Has ganado!");
                        break;
                    }
                    else
                    {
                        Diez = 0;
                    }
                }

                if (turnos > 3 && (dado == 1 || dado == 3 || dado == 5 || dado == 7 || dado == 9 || dado == 11))
                {
                    Console.WriteLine("Su total fue " + total + " puntos");
                    total = 0;
                    Console.WriteLine("Has perdido");
                    break;
                }

                if (total < 100 && total != 100)
                {
                    total += dado;
                    Console.WriteLine(" Total = " + total);

                    if (total >= 100)
                    {
                        Console.WriteLine("Su total fue " + total + " puntos");
                        Console.WriteLine(" Has ganado");
                        break;
                    }

                    Console.WriteLine("Volver a tirar (s)?: ");
                    Tirar = Console.ReadLine();
                }              

            }
        }
    }
}
