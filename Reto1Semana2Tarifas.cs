using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1Semana2Tarifas
{
    class Program
    {
        static void Main(string[] args)
        {
            int smmlv = 908526;
            Console.Write("Ingrese su Salario: ");
            int Salario = int.Parse(Console.ReadLine());

            if (Salario > 4 * smmlv)
            {
                Console.WriteLine("Deberas pagar la tarifa C");
            }
            else if (Salario >= 2 * smmlv && Salario < 4 * smmlv)
            {
                Console.WriteLine("Deberas pagar la tarifa B");
            }
            else if (Salario < 2 * smmlv)
            {
                Console.WriteLine("Deberas pagar la tarifa A");
            }
            Console.ReadLine();

            // link del video https://youtu.be/7yZ-EHF0SBU
        }
    }
}
