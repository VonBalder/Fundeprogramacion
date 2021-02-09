using System;

namespace DesafioSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {                     
                     
            Console.Write("Escriba el Salario que recibe ");
            
            int Salario = int.Parse(Console.ReadLine());

            double baseCotizacion = 0.4 * Salario;
            int smmlv = 908526;
            double EPS = 0;
            double ARL = 0;
            double Pension = 0;
            double deducciones;
            double SalarioReal;
            double IngresosAnuales;           

            Console.Write("Ingresa 1 si es independiente , 2 si es dependiente ");
            int TipodeContrato = int.Parse(Console.ReadLine());

            switch(TipodeContrato)
            {
               
                case 1:
                    Console.WriteLine("es independiente");                   
                    Console.Write("Ingresa riesgo ");
                    int RiesgoLaboral = int.Parse(Console.ReadLine());

                    switch (RiesgoLaboral)
                    {
                        case 1:
                            Console.WriteLine("el riesgo laboral es 1");
                            ARL = baseCotizacion * 0.0052;
                            Console.WriteLine($"ARL {ARL}");
                            EPS = baseCotizacion * 0.125;
                            Console.WriteLine($"EPS {EPS}");
                            Pension = baseCotizacion * 0.16;
                            Console.WriteLine($"Pension {Pension}");
                            deducciones = ARL + EPS + Pension;
                            Console.WriteLine($"deducciones {deducciones}");
                            SalarioReal = Salario - deducciones;
                            Console.WriteLine($"SalarioReal {SalarioReal}");
                            IngresosAnuales = SalarioReal * 12;
                            Console.WriteLine($"IngresosAnuales {IngresosAnuales}");
                            break;
                        case 2:
                            Console.WriteLine("el riesgo laboral es 2");
                            ARL = baseCotizacion * 0.0104;
                            Console.WriteLine($"ARL {ARL}");
                            EPS = baseCotizacion * 0.125;
                            Console.WriteLine($"EPS {EPS}");
                            Pension = baseCotizacion * 0.16;
                            Console.WriteLine($"Pension {Pension}");
                            deducciones = ARL + EPS + Pension;
                            Console.WriteLine($"deducciones {deducciones}");
                            SalarioReal = Salario - deducciones;
                            Console.WriteLine($"SalarioReal {SalarioReal}");
                            IngresosAnuales = SalarioReal * 12;
                            Console.WriteLine($"IngresosAnuales {IngresosAnuales}");
                            break;
                        case 3:
                            Console.WriteLine("el riesgo laboral es 3");
                            ARL = baseCotizacion * 0.0244;
                            Console.WriteLine($"ARL {ARL}");
                            EPS = baseCotizacion * 0.125;
                            Console.WriteLine($"EPS {EPS}");
                            Pension = baseCotizacion * 0.16;
                            Console.WriteLine($"Pension {Pension}");
                            deducciones = ARL + EPS + Pension;
                            Console.WriteLine($"deducciones {deducciones}");
                            SalarioReal = Salario - deducciones;
                            Console.WriteLine($"SalarioReal {SalarioReal}");
                            IngresosAnuales = SalarioReal * 12;
                            Console.WriteLine($"IngresosAnuales {IngresosAnuales}");
                            break;
                        case 4:
                            Console.WriteLine("el riesgo laboral es 4");
                            ARL = baseCotizacion * 0.0435;
                            Console.WriteLine($"ARL {ARL}");
                            EPS = baseCotizacion * 0.125;
                            Console.WriteLine($"EPS {EPS}");
                            Pension = baseCotizacion * 0.16;
                            Console.WriteLine($"Pension {Pension}");
                            deducciones = ARL + EPS + Pension;
                            Console.WriteLine($"deducciones {deducciones}");
                            SalarioReal = Salario - deducciones;
                            Console.WriteLine($"SalarioReal {SalarioReal}");
                            IngresosAnuales = SalarioReal * 12;
                            Console.WriteLine($"IngresosAnuales {IngresosAnuales}");
                            break;
                        case 5:
                            Console.WriteLine("el riesgo laboral es 5");
                            ARL = baseCotizacion * 0.0696;
                            Console.WriteLine($"ARL {ARL}");
                            EPS = baseCotizacion * 0.125;
                            Console.WriteLine($"EPS {EPS}");
                            Pension = baseCotizacion * 0.16;
                            Console.WriteLine($"Pension {Pension}");
                            deducciones = ARL + EPS + Pension;
                            Console.WriteLine($"deducciones {deducciones}");
                            SalarioReal = Salario - deducciones;
                            Console.WriteLine($"SalarioReal {SalarioReal}");
                            IngresosAnuales = SalarioReal * 12;
                            Console.WriteLine($"IngresosAnuales {IngresosAnuales}");
                            break;

                        default:
                            Console.WriteLine("el tipo de contrato es desconocido");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("es dependiente");
                    ARL = 0;
                    Console.WriteLine($"ARL {ARL}");
                    EPS = baseCotizacion * 0.04;
                    Console.WriteLine($"EPS {EPS}");
                    Pension = baseCotizacion * 0.04;
                    Console.WriteLine($"Pension {Pension}");
                    deducciones = ARL + EPS + Pension;
                    Console.WriteLine($"deducciones {deducciones}");
                    SalarioReal = Salario - deducciones;
                    Console.WriteLine($"SalarioReal {SalarioReal}");
                    IngresosAnuales = SalarioReal * 12 + Salario;
                    Console.WriteLine($"IngresosAnuales {IngresosAnuales}");
                    break;

                default:
                    Console.WriteLine("el tipo de contrato es desconocido");
                    break;
            }

            // link del video https://youtu.be/-I1V4dWTAe8
        }
    }
}
