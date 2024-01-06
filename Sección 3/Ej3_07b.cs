/*
 * Programa que pide al usuario un número y calcula su 
 * raíz cúbica.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        int numero;
        double raizCubica;
        
        Console.WriteLine("Escribe el número:");
        numero = Convert.ToInt32(Console.ReadLine());
        
        raizCubica = Math.Pow(numero, 1/3.0);
        Console.WriteLine("La raíz cúbica es {0}", raizCubica.ToString("N3"));
    }
}


