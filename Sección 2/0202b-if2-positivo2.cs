using System;

class Positivo
{
    static void Main()
    {
        int n;

        Console.Write("Dime un n�mero: ");
        n = Convert.ToInt32( Console.ReadLine() );

        if ( ! (n < 0) )
            Console.WriteLine("Es positivo o cero");
        else
            Console.WriteLine("Es negativo");
    }
}

