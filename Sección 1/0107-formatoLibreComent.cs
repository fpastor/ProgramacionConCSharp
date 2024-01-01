// Programa que suma dos numeros
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

        Console.Write("Su suma es: ");
        Console.WriteLine(a+b);
    }
}
