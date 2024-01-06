/*
 * Programa que pide al usuario dos números (base y exponente)
 * y calcula la potencia con ellos (base elevado a exponente)
 * mediante multiplicaciones sucesivas.
 * 
 * Por Nacho Iborra
 */ 
 
using System;

public class Ejemplo
{    
    static void Main()
    {
        int numeroBase, numeroExponente, resultado;
        
        Console.WriteLine("Escribe la base:");
        numeroBase = Convert.ToInt32( Console.ReadLine() );
        Console.WriteLine("Escribe el exponente:");
        numeroExponente = Convert.ToInt32( Console.ReadLine() );
        
        if (numeroExponente < 0)
        {
            Console.WriteLine("Imposible calcular potencia entera");
        }
        else
        {
            resultado = 1;
            for (int i = 1; i <= numeroExponente; i++)
            {
                resultado = resultado * numeroBase;
            }
            Console.WriteLine("Resultado: {0}}", resultado);
        }
    }
}


