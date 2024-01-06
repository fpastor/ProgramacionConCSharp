using System;

class Division 
{
    static void Main() 
    {
        int a, b;

        try
        {
            Console.Write("Dime el dividendo: ");
            a = Convert.ToInt32( Console.ReadLine() );
            Console.Write("Dime el divisor: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Su división es: ");
            Console.WriteLine( a / b );
        }
        catch (FormatException)
        {
            Console.WriteLine("Ese número no es válido");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("No se puede dividir");
        }
        Console.WriteLine("...");
    }
}

