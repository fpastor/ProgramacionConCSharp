using System;

class Variables
{
    static void Main()
    {
        int a, b;

        Console.Write("Dime el primer n�mero: ");
        a = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Dime el segundo n�mero: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Su suma es: ");
        Console.WriteLine(a+b);
    }
}

