/*
 * Programa que convierte de grados Celsius a grados Kelvin y Fahrenheit.
 * 
 * Por Nacho Iborra
 */ 
 
using System;

public class Ejemplo
{    
    static void Main()
    {
        int celsius, kelvin, fahrenheit;
        
        Console.WriteLine("Introduce temperatura Celsius:");
        celsius = Convert.ToInt32( Console.ReadLine() );
        
        kelvin = celsius + 273;
        fahrenheit = celsius * 18 / 10 + 32;
        
        Console.WriteLine("{0}º Celsius = {1}º Kelvin", 
            celsius, kelvin);

        Console.Write(celsius);
        Console.Write("º Celsius = ");
        Console.Write(fahrenheit);
        Console.WriteLine("º Fahrenheit");
    }
}


