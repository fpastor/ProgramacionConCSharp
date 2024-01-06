using System;

class DoWhile1 
{
    static void Main() 
    {
        int a, b;

        Console.Write("Dime el dividendo: ");
        a = Convert.ToInt32( Console.ReadLine() );
        
        do
        {
            Console.Write("Dime el divisor: ");
            b = Convert.ToInt32(Console.ReadLine());
            
            if (b == 0)
                Console.WriteLine("No puedo dividir");
        }
        while (b == 0);
            
        Console.Write("Su división es: ");
        Console.WriteLine( a / b );
    }
}

