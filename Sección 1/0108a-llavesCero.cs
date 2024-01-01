// Programa que suma dos números, ejemplo de {0}, {1}, ...
// Por Nacho Cabanes

using System;

class Variables
{
    static void Main()
    {
        int a, b;

        Console.Write("Dime el primer número: ");
        a = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Dime el segundo número: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("La suma de {0} y {1} es: {2}", 
            a, b, a+b);
    }
}
