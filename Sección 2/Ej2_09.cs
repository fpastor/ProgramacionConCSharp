/*
 * Programa de práctica de las instrucciones 
 * "break" y "continue":
 * - Contar del 1 al 20 saltando el 10 con "continue"
 * - Contar del 1 al 20 pero parar en el 10 usando "break"
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        Console.WriteLine("Números del 1 al 20 saltando el 10:");
        
        for(int i = 1; i <= 20; i++)
        {
            if (i == 10)
            {
                continue;
            }
            Console.WriteLine(i);
        }
        
        Console.WriteLine("Números del 1 al 20 parando en el 10:");
        
        for(int i = 1; i <= 20; i++)
        {
            if (i == 10)
            {
                break;
            }
            Console.WriteLine(i);
        }
        
        Console.WriteLine("Fin del programa.");
    }
}


