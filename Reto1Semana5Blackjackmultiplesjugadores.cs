using System;

namespace Blackjackmultiplesjugadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerojugadores = 0, jugadores = 0;

            while (true)
            {
                Console.WriteLine("Ingrese el numero de jugadores: ");
                numerojugadores = int.Parse(Console.ReadLine());

                if (numerojugadores <= 1)
                {
                    Console.WriteLine("Deben sere entre 2 a 5 personas, ingrese de nuevo");
                }
                if (numerojugadores > 5)
                {
                    Console.WriteLine("Deben sere entre 2 a 5 personas, ingrese de nuevo");
                }
                else if (numerojugadores >= 2 && numerojugadores <= 5)
                {

                    break;
                }
            }
            
            while (true)                
            {
                Random aleatorio = new Random();
                jugadores ++;
                Console.WriteLine("es el turno del jugador" + jugadores);

                int Card1 = aleatorio.Next(1, 11);
                int Card2 = aleatorio.Next(1, 11);
                Console.WriteLine("Carta 1 " + Card1);
                Console.WriteLine("Carta 2 " + Card2);

                int ExtraCard = 0;
                int all = Card1 + Card2;
                string Continue = "s";


                while (Continue == "s" && all < 21)
                    {

                    Console.WriteLine("Total  " + all);
                    Console.Write("Deseas pedir otra carta? (s): ");
                    Continue = Console.ReadLine();

                    if (all <= 21)
                    {
                        ExtraCard = aleatorio.Next(1, 11);
                        Console.WriteLine("Nueva carta " + ExtraCard);
                        all += ExtraCard;
                    }
                }

                if (all == 21)
                {
                    Console.WriteLine("Blackjack");
                    Continue = "n";
                    break;
                }
                if (Continue != "s")
                {
                    Console.WriteLine("Te has retirado,Gracías por participar");
                    Continue = "n";
                    break;
                }

                if (numerojugadores == jugadores)
                {
                    Console.WriteLine("FIN DEL JUEGO");
                    break;
                }
            }
        }
    }
}