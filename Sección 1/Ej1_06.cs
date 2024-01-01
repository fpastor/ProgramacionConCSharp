using System;

public class Ej1_06
{    
    static void Main()
    {
        int a, b;

        Console.Write("Dime el primer número: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dime el segundo número: ");
        b = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("(a+b)*(a-b) = ");
        Console.WriteLine((a+b)*(a-b));
        Console.Write("a2-b2 = ");
        Console.WriteLine(a*a - b*b);
    }
}


