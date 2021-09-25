using System;

namespace MediaAritimetica
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, m;
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n==== Calcular Média Aritimética ====\n");
            Console.ResetColor();

            Console.WriteLine("Me diga o valor de 3 números para\nque seja possível calcular a média.\n");

            Console.Write("Número 1..: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Número 2..: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Número 3..: ");
            n3 = Convert.ToDouble(Console.ReadLine());
            
            m = (n1 + n2 + n3) / 3;
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n=== Resultado ===\n");
            Console.ResetColor();

            Console.WriteLine($"A média entre os três números é {m:N1}\n");
        }
    }
}
