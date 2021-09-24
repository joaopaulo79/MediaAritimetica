using System;

namespace MediaAritimetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("==== Calcular Média Aritimética ==== ");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Me diga o valor de 3 números para que");
            Console.WriteLine("seja possível calcular a média.");
            Console.WriteLine();
            Console.Write("Número 1..: ");
            string numero1 = Console.ReadLine();
            double n1 = Convert.ToDouble(numero1);
            Console.Write("Número 2..: ");
            string numero2 = Console.ReadLine();
            double n2 = Convert.ToDouble(numero2);
            Console.Write("Número 3..: ");
            string numero3 = Console.ReadLine();
            double n3 = Convert.ToDouble(numero3);
            double m = (n1 + n2 + n3) / 3;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=== Resultado ===");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine($"A média entre os três números é {m:N1}");
            Console.WriteLine();
        }
    }
}
