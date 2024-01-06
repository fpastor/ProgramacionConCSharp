using System;
internal class Program
{
    static void Main()
    {
        int value, actualValue, count = 0;

        // VERSIÓN 1

        Console.WriteLine("Escribe un número:");
        value = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < value; i++)
        {
            if (value % i == 0)
            {
                count++;
            }
        }
        if (count > 2)
        {
            Console.WriteLine("El número NO es primo");
        }
        else
        {
            Console.WriteLine("El número SI es primo");
        }

        // VERSIÓN 2

        actualValue = 2;

        while (value % actualValue != 0)
        {
            actualValue++;
        }

        if (value == actualValue)
        {
            Console.WriteLine("El número SI es primo");
        }
        else
        {
            Console.WriteLine("El número NO es primo");
        }

    }
}