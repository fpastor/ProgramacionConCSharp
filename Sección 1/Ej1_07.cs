// Programa que calcula la equivalencia entre metros y millas
// Por Nacho Iborra

using System;

public class Ejercicio
{    
    static void Main()
    {
        int metros;
        
        Console.WriteLine("Dime la cantidad de metros:");
        metros = Convert.ToInt32(Console.ReadLine());
        
        Console.Write(metros);
        Console.Write(" son ");
        Console.Write(metros / 1609.344);
        Console.WriteLine(" millas.");
    }
}


