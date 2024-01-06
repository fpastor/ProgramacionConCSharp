/*
 * Ejemplo de uso de operaciones abreviadas, autoincrementos
 * y autodecrementos para determinar el valor final de las
 * variables.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        int a = 12;
        a--;            // a = 11     
        Console.WriteLine(a);
        a *= 3;         // a = 33
        Console.WriteLine(a);
        a -= 5;         // a = 28
        Console.WriteLine(a);
        a %= 6;         // a = 4
        Console.WriteLine(a);
        int b = a++;    // b = 4, a = 5
        Console.WriteLine("{0} {1}", a, b);
    }
}


