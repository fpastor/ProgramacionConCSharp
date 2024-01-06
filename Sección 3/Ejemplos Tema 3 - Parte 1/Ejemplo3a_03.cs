/*
 * Programa que calcula el porcentaje de chicos y chicas en una clase.
 * 
 * Por Nacho Iborra
 */ 
 
using System;

public class Ejemplo
{    
    static void Main()
    {
        int totalChicos, totalChicas, totalAlumnos;
        float porcentajeChicos, porcentajeChicas;
        
        Console.WriteLine("Introduce el total de chicos:");
        totalChicos = Convert.ToInt32( Console.ReadLine() );
        Console.WriteLine("Introduce el total de chicas:");
        totalChicas = Convert.ToInt32( Console.ReadLine() );

        totalAlumnos = totalChicos + totalChicas;
        porcentajeChicos = totalChicos * 100 / (float)totalAlumnos;
        porcentajeChicas = totalChicas * 100 / (float)totalAlumnos;
        
        Console.WriteLine("Chicos: {0}%", porcentajeChicos.ToString("N2"));
        Console.WriteLine("Chicas: {0}%", porcentajeChicas.ToString("N2"));
    }
}


