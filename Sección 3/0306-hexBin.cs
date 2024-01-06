using System;
class HexBin
{
    static void Main()
    {
        int dato = 300;
        Console.Write( "En binario es: ");
        Console.WriteLine( Convert.ToString(dato, 2) );
        Console.Write("En hexadecimal es: ");
        Console.WriteLine(Convert.ToString(dato, 16));

        Console.Write("Dime un dato binario: ");
        Console.WriteLine("En decimal es: {0}",
            Convert.ToInt32( Console.ReadLine(), 2) );
        Console.Write("Dime un dato hexadecimal: ");
        Console.WriteLine("En decimal es: {0}",
            Convert.ToInt32(Console.ReadLine(), 16));
    }
}
