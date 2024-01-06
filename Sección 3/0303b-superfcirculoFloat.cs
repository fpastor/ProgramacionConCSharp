using System;
class Circunferencia2
{
    static void Main()
    {
        Console.WriteLine("Dime el radio: ");
        float radio = Convert.ToSingle(Console.ReadLine());

        float pi = 3.14159263359f;
        float longitud = 2 * pi * radio;
        Console.WriteLine("La longitud es {0}", longitud);
    }
}
