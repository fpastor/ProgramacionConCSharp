/*
 * Programa que pide un número al usuario y responde si es primo.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        int numero, numeroActual, contadorDivisores = 0;
        
        Console.WriteLine("Escribe un número:");
        numero = Convert.ToInt32(Console.ReadLine());

        // Primera alternativa

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                contadorDivisores += 1;
            }
        }
        
        if (contadorDivisores > 2)
        {
            Console.WriteLine("El número NO es primo");
        }
        else
        {
            Console.WriteLine("El número SI es primo");
        }
        
        // Segunda alternativa
        
        numeroActual = 2;
        
        while (numero % numeroActual != 0)
        {
            numeroActual += 1;
        }
        
        if (numero == numeroActual)
        {
            Console.WriteLine("El número SI es primo");            
        }
        else
        {
            Console.WriteLine("El número NO es primo");
        }
    }
}


