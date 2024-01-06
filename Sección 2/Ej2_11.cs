/*
 * Programa en que el usuario debe adivinar un número entre 1 y 100,
 * con un número ilimitado de intentos, y avisando tras cada intento
 * al usuario de si se ha pasado o se ha quedado corto.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        int numero, numeroSecreto = 78;
        
        do
        {
            Console.WriteLine("Escribe un número del 1 al 100:");
            numero = Convert.ToInt32(Console.ReadLine());
            
            if (numero == numeroSecreto)
            {
                Console.WriteLine("Has acertado");
            }
            else
            {
                if (numero > numeroSecreto)
                {
                    Console.WriteLine("Te has pasado");
                }
                else
                {
                    Console.WriteLine("Te has quedado corto");
                }
            }
        } 
        while (numero != numeroSecreto);
    }
}


