using System;

class While1 
{
    static void Main() 
    {
        int a, b;

        Console.Write("Dime el dividendo: ");
        a = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Dime el divisor: ");
        b = Convert.ToInt32(Console.ReadLine());

        while (b == 0)  
        {
            Console.WriteLine("No puedo dividir");
            
            Console.Write("Dime el divisor: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
            
        Console.Write("Su división es: ");
        Console.WriteLine( a / b );
    }
}

