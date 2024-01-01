/*
 * Programa que pide al usuario dos números enteros y realiza la división
 * entre ellos, comprobando previamente si el segundo número es 0.
 * 
 * Por Nacho Iborra
 */ 
 
using System;

public class Ejemplo
{    
    static void Main()
    {
        int dividendo, divisor;
        
        Console.WriteLine("Dime los dos números:");
        dividendo = Convert.ToInt32( Console.ReadLine() );
        divisor = Convert.ToInt32( Console.ReadLine() );
        
        if (divisor != 0)
        {
            Console.WriteLine("Resultado: {0}",
                dividendo / divisor);
        }
        else
        {
            Console.WriteLine("Error: no se puede dividir por cero");
        }
    }
}


