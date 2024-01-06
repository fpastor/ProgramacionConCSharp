/*
 * Programa que pide al usuario el radio de un círculo
 * y muestra su superficie (pi * radio al cuadrado)
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        float radio, superficie;
        
        Console.WriteLine("Introduce el radio del círculo:");
        radio = Convert.ToSingle( Console.ReadLine() );
        
        superficie = 3.14159f * radio * radio;
        Console.WriteLine("La superficie es {0}", superficie);
    }
}


