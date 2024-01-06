using System;
internal class Program
{
    static void Main()
    {

        Console.WriteLine("Números del 1 al 200 que son múltiplos de 3 y 7:");
        for (int i = 1; i <= 200; i++)
        {
            if ((i % 3) == 0 && (i % 7) == 0)
            {
                Console.WriteLine(i);
            }
        }

    }
}