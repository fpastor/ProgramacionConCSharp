/*
 * Programa que pide al usuario los catetos de un triángulo
 * rectángulo y calcula la hipotenusa utilizando el teorema
 * de Pitágoras.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        int a, b;
        double h;
        
        Console.WriteLine("Introduce el valor de a:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce el valor de b:");
        b = Convert.ToInt32(Console.ReadLine());
        
        h = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        Console.WriteLine("La hipotenusa es {0}", h.ToString("N3"));
    }
}


