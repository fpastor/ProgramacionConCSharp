/*
 * Programa que pide al usuario un carácter y le indica si se 
 * trata de un dígito, una letra en minúsculas o cualquier otro símbolo.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        char caracter;
        
        Console.WriteLine("Introduce un carácter:");
        caracter = Convert.ToChar( Console.ReadLine() );

        if (caracter >= '0' && caracter <= '9')
        {
            Console.WriteLine("Es un dígito");
        }
        else if (caracter >= 'a' && caracter <= 'z')
        {
            Console.WriteLine("Es una letra minúscula");
        }
        else
        {
            Console.WriteLine("Es cualquier otro símbolo");
        }
    }
}


