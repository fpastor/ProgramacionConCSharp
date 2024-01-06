/*
 * Programa de práctica del bucle for para mostrar
 * tres secuencias distintas:
 * - Números del 1 al 20
 * - Números pares del 2 al 16
 * - Números impares del 15 al 5, descendente
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        Console.WriteLine("Números del 1 al 20:");
        
        for(int i = 1; i <= 20; i = i+1)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine("Números pares del 2 al 16:");
        
        for(int i = 2; i <= 16; i = i+2)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine("Números impares del 15 al 5:");
        
        for(int i = 15; i >= 5; i = i-2)
        {
            Console.WriteLine(i);
        }
    }
}


