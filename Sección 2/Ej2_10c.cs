/*
 * Programa que muestra todos los divisores del número
 * que introduzca el usuario.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        int numero;
        
        Console.WriteLine("Escribe un número:");
        numero = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Mostrando los divisores de {0}:", numero);
        
        for (int i = numero; i >= 1; i -= 1)
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);
            }
        }        
    }
}


