using System;

namespace Reto2Semana4DadosCaso1
{
    class Program
    {
        static void Main(string[] args)
        {

            // video Youtube https://youtu.be/9wn-wdazu4s
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, total = 0, Totalseis = 0, ContadorDobles = 0;
            double turnos = 0, Seis = 0;
            bool Dobles1 = false;
            String Tirar = "s";

            Console.WriteLine("Empezar a tirar (s)?");
            Tirar = Console.ReadLine();

            if (Tirar != "s")
            {
                Console.WriteLine("Te has retirado,Gracías por participar");
                Tirar = "n";
            }

            while (Tirar == "s" || total <= 100)
            {
                dado1 = aleatorio.Next(1, 7);
                dado2 = aleatorio.Next(1, 7);
                turnos += 1;

                Totalseis = dado1 + dado2;

                Console.WriteLine("Primer Dado = " + dado1);
                Console.WriteLine("Segundo Dado = " + dado2);
                Console.WriteLine("Estas en el turno " + turnos);

                if (Totalseis >= 6)
                {
                    Seis += 1;
                    Console.WriteLine("Hasta ahora has obtenido la siguiente cantidad de dados Superiores a seis " + Seis);
                    Totalseis = 0;
                }
                if (dado1 == 1 && dado2 == 1)
                {
                    Dobles1 = true;
                }
                if (Dobles1 == true)
                {
                    Console.WriteLine("Has perdido, buena suerte para la proxima");
                    break;
                }

                if (dado1 == dado2 && Dobles1 == false)
                {
                    ContadorDobles += 1;
                    Console.WriteLine("Su contador doble es  " + ContadorDobles);
                }
                if (total < 100 && total != 100)
                {
                    total += dado1 + dado2;
                    Console.WriteLine(" Total = " + total);

                    if (total >= 100 || ContadorDobles == 3)
                    {
                        Console.WriteLine("Su total fue " + total + " puntos");
                        Console.WriteLine(" Has ganado");
                        double promedio = (Seis / turnos)*100;
                        Console.WriteLine("El promedio de turnos en los que el numero fue mayor a 6 es " + promedio);
                        break;
                    }

                    Console.WriteLine("Volver a tirar (s)?: ");
                    Tirar = Console.ReadLine();
                }
            }

           
        }
    }
}
