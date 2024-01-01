using System;

internal class Program
{
    static void Main()
    {
        int dividendo, divisor;

        Console.WriteLine("DIVISIÓN");
        Console.WriteLine("");
        Console.Write("Introduce el dividendo: ");
        dividendo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el divisor: ");
        divisor = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        if (divisor != 0)
        {
            Console.WriteLine("El resultado de la división {0} entre {1} es {2}", dividendo, divisor, dividendo / divisor);
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: No se puede dividir por cero.");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}