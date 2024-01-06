using System;
class Formatos
{
    static void Main()
    {
        double n = 12.34;
        Console.WriteLine(n.ToString("N1"));
        Console.WriteLine(n.ToString("N3"));
        Console.WriteLine(n.ToString("0.0"));
        Console.WriteLine(n.ToString("0.000"));
        Console.WriteLine(n.ToString("#.#"));
        Console.WriteLine(n.ToString("#.###"));
    }
}
