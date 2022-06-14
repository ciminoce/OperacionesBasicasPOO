using System;
using OperacionesBasicasPOO.Entidades;

namespace OperacionesBasicasPOO.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"{Calculadora.Calcular(4,2,'+')}");
                Console.WriteLine($"{Calculadora.Calcular(4,2,'-')}");
                Console.WriteLine($"{Calculadora.Calcular(4,2,'*')}");
                Console.WriteLine($"{Calculadora.Calcular(4,0,'/')}");

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}
