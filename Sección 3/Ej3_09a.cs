/*
 * Programa que pide al usuario dos letras mayúsculas y muestra la 
 * secuencia desde la menor de ellas hasta la mayor, ambas inclusive.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        char l1, l2, menor, mayor;
        
        Console.WriteLine("Introduce dos letras mayúsculas:");
        l1 = Convert.ToChar( Console.ReadLine() );
        l2 = Convert.ToChar( Console.ReadLine() );
        
        if (l1 < l2)
        {
            menor = l1;
            mayor = l2;
        }
        else
        {
            menor = l2;
            mayor = l1;
        }
        
        for (char c = menor; c <= mayor; c++)
        {
            Console.WriteLine(c);
        }
    }
}


