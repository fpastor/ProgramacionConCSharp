using System;
internal class Program
{
    static void Main()
    {

        int value, result = 0;

        Console.WriteLine("Dime números. Escribe 0 para finalizar");

        do
        {
            value = Convert.ToInt32(Console.ReadLine());
            if (value != 0)
            {
                result += value;
                Console.WriteLine("Suma hasta ahora: {0}", result);
            }
        }
        while (value != 0);

    }
}