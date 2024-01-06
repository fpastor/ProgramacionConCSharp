using System;
class Formatos
{
    static void Main()
    {
        double n = 912.3456123456;
        Console.WriteLine(n);
        Console.WriteLine( Convert.ToSingle(n) );
        Console.WriteLine( (float) n );
        Console.WriteLine( Convert.ToInt32(n) );
        Console.WriteLine( (int) n );
    }
}
