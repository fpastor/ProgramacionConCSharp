using System;
class Circunferencia
{
    static void Main()
    {
        Console.WriteLine("Dime el radio: ");
        double radio = Convert.ToDouble( Console.ReadLine() );

        double pi = 3.14;
        double longitud = 2 * pi * radio;
        Console.WriteLine("La longitud es {0}", longitud);
    }
}
