/*
 * Programa que pide al usuario números hasta que introduzca el 
 * valor 0. Para cada número, mostrará el resultado de la suma
 * de los números introducidos hasta ese momento.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        int numero, suma = 0;
        
        Console.WriteLine("Escribe números. Escribe 0 para finalizar");
        
        do
        {
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero != 0)
            {
                suma += numero;
                Console.WriteLine("Suma hasta ahora: {0}", suma);
            }
        }
        while (numero != 0);
    }
}


