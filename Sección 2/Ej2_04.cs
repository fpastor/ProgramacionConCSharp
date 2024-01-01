/*
 * Programa que le pide al usuario dos números e indica
 * cuántos de ellos son positivos, empleando el operador
 * ternario para ello.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        int num1, num2, cantidadDePositivos;
        
        Console.WriteLine("Introduce el primer número:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce el segundo número:");
        num2 = Convert.ToInt32(Console.ReadLine());
                
        cantidadDePositivos = (num1 >= 0 && num2 >= 0) ? 2 : 
            ((num1 < 0 && num2 < 0) ? 0 : 1);
        
        Console.WriteLine("Has introducido {0} números positivos", cantidadDePositivos);
    }
}


