using System;

class Variables
{
    static void Main()
    {
        int a, b;

        Console.Write("Dime el dividendo: ");
        a = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Dime el divisor: ");
        b = Convert.ToInt32(Console.ReadLine());

        if (b != 0)
        {
            Console.Write("Su división es: ");
            Console.WriteLine( a / b );
        }
        else
            Console.WriteLine("No puedo dividir");
        
        Console.WriteLine("Hasta luego");
    }
}

