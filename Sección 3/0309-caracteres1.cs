using System;

class Caracteres
{
    static void Main()
    {
        for (char c = 'a'; c <= 'z'; c++)
        {
            Console.Write(c);
        }
        Console.WriteLine();

        Console.Write("Introduce un símbolo: ");
        char l = Convert.ToChar(Console.ReadLine());
        if (l >= '0' && l <= '9')
            Console.WriteLine("Es un dígito");
        else if (l == '.' || l == ',')
            Console.WriteLine("Es un símbolo de puntuación");
        else
            Console.WriteLine("No sé lo que es");
    }
}

