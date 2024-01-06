using System;
internal class Program
{
    static void Main()
    { 
        Console.Write("Números de 1 a 20: ");
        for (int i = 1; i <=20;  i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("");

        //Console.Write("Números pares de 2 a 16: ");
        //for (int i = 2; i <= 16; i++)
        //{
        //    if((i % 2) == 0)
        //    {
        //        Console.Write(i + " ");
        //    }
        //}
        //Console.WriteLine("");

        Console.Write("Números pares de 2 a 16: ");
        for (int i = 2; i <= 16; i = i + 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("");

        //Console.Write("Números impares de 15 a 5,descendiendo: ");
        //for (int i = 15; i >= 5; i--)
        //{
        //    if ((i % 2) != 0)
        //    {
        //        Console.Write(i + " ");
        //    }
        //}
        //Console.WriteLine("");

        Console.Write("Números impares de 15 a 5,descendiendo: ");
        for (int i = 15; i >= 5; i = i - 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("");
    }
}
