using System;

class NumerosBinarios
{
    static void Main()
    {
        int n1 = 62;
        int n2 = Convert.ToInt32("11001101", 2);
        int n3 = 0b10101110;

        Console.WriteLine( n2 | n3 );

        Console.WriteLine( Convert.ToString(n2, 2));
        Console.WriteLine( Convert.ToString(n3, 2));
        Console.WriteLine( Convert.ToString(n2 | n3, 2) + " OR");
        Console.WriteLine( Convert.ToString(n2 & n3, 2) + " AND");
        Console.WriteLine( Convert.ToString(n2 ^ n3, 2) + " XOR");

        Console.WriteLine( Convert.ToString(~ n3, 2) + " NOT");
        Console.WriteLine();
        Console.WriteLine(n3);
        Console.WriteLine( Convert.ToString( n3 >> 2, 2) + " >>");
        Console.WriteLine( n3 >> 2);
        Console.WriteLine(Convert.ToString( n3 << 2, 2) + " <<");
        Console.WriteLine( n3 << 2);

    }
}
