/*
 * Programa que pide al usuario un ángulo en grados, y
 * muestra su seno, coseno y tangente.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        int angulo;
        double radianes;
        
        Console.WriteLine("Escribe el ángulo en grados:");
        angulo = Convert.ToInt32(Console.ReadLine());
        
        radianes = angulo * Math.PI / 180;
        Console.WriteLine("El seno es {0}", Math.Sin(radianes));
        Console.WriteLine("El coseno es {0}", Math.Cos(radianes));
        Console.WriteLine("La tangente es {0}", Math.Tan(radianes));        
    }
}


