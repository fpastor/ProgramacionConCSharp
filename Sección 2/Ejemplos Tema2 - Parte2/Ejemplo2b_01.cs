/*
 * Programa que pide al usuario un número y realiza la cuenta atrás
 * desde ese número hasta 0, siempre y cuando el número esté
 * comprendido entre 1 y 10, inclusive.
 * 
 * Por Nacho Iborra
 */ 
 
using System;

public class Ejemplo
{    
    static void Main()
    {
        int numero;

        do
        {
            Console.WriteLine("Dime un número entre 1 y 10:");
            numero = Convert.ToInt32( Console.ReadLine() );
        } while (numero < 1 || numero > 10);

        Console.WriteLine("Cuenta atrás de {0} a 1:", numero);
        for (int i = numero; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }
}


