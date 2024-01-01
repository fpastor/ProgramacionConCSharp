using System;

public class Ej1_05
{    
    static void Main()
    {
        int numero1, numero2;

        Console.Write("Dime el primer número: ");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dime el segundo número: ");
        numero2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Su división es: ");
        Console.WriteLine(numero1 / numero2);
        Console.Write("Su resto es: ");
        Console.WriteLine(numero1 % numero2);
    }
}


