using System;

class Depuracion
{
    static void Main()
    {
        int a, b, c;

        a = 5;
        a = a * 7 + 9 / 3;
        b = a - 2;
        c = b * 2;
        if (a - 15 > 20)
        {
            b = b - 5;
        }
        c = b - a * 2;
        Console.WriteLine(c);
    }
}
