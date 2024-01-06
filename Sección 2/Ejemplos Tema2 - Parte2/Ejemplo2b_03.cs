/*
 * Programa que pide al usuario una altura y dibuja 
 * un triángulo de esa altura.
 * 
 * Por Nacho Iborra
 */ 
 
using System;

public class Ejemplo
{    
    static void Main()
    {
        int alturaTriangulo;
        
        Console.WriteLine("Introduce la altura del triángulo:");
        alturaTriangulo = Convert.ToInt32( Console.ReadLine() );
        
        // Primer bucle: va fila por fila
        for (int i = 0; i < alturaTriangulo; i++)
        {
            // Segundo bucle: rellena cada fila
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}


