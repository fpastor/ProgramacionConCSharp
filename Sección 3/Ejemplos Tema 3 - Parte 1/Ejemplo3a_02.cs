/*
 * Programa de prueba para tratar de averiguar el valor final de la variable
 * "n".
 * 
 * Por Nacho Iborra
 */ 
 
using System;

public class Ejemplo
{    
    static void Main()
    {
        int n = 1, a = 3, b = 4;
        a = b + n++;                // a = 5, b = 4, n = 2
        n *= 3;                     // n = 6
        n = n + a + b * a;          // n = 6 + 5 + 20 = 31
        
        Console.WriteLine(n);
    }
}


