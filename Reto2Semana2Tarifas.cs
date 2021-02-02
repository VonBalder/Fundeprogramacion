
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto2Semana2Tarifas
{
    class Program
    {
        static void Main(string[] args)
        {
            int smmlv = 908526;
            Console.Write("Ingrese su Salario: ");
            int Salario = int.Parse(Console.ReadLine());

            if (Salario > 5 * smmlv)
            {
                Console.WriteLine("Deberas pagar la tarifa C, La cuota moderadora en sura es 36.800");
            }
            else if (Salario >= 2 * smmlv && Salario < 5 * smmlv)
            {
                Console.WriteLine("Deberas pagar la tarifa B, La cuota moderadora en sura es 14.000");
            }
            else if (Salario < 2 * smmlv)
            {
                Console.WriteLine("Deberas pagar la tarifa A, La cuota moderadora en sura es 3.500");
            }
            Console.ReadLine();

            // link de video https://youtu.be/7yZ-EHF0SBU
        }
    }
}
