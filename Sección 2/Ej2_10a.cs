/*
 * Programa que muestra los números del 1 al 200 
 * que sean múltiplos de 3 y de 7 a la vez.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        for(int i = 1; i <= 200; i = i+1)
        {
            if (i % 3 == 0 && i % 7 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}


