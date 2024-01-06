using System;
internal class Program
{
    static void Main()
    {

        int value = 0;

        Console.WriteLine("Dime un número:");
        value = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Los divisores para {0} son: ", value);

        for (int i = 1; i <= value; i++)
        {
            if (value % i == 0)
            {
                Console.WriteLine(i);
            }
        }

    }
}