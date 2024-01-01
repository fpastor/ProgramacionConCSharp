/*
 * Programa que pide al usuario tres notas de exámenes y le muestra
 * un mensaje u otro dependiendo de los valores de esas notas.
 * 
 * Por Nacho Iborra
 */ 
 
using System;

public class Ejemplo
{    
    static void Main()
    {
        int nota1, nota2, nota3;
        
        Console.WriteLine("Dime las tres notas:");
        nota1 = Convert.ToInt32( Console.ReadLine() );
        nota2 = Convert.ToInt32( Console.ReadLine() );
        nota3 = Convert.ToInt32( Console.ReadLine() );
        
        if (nota1 >= 5 && nota2 >= 5 && nota3 >= 5)
        {
            Console.WriteLine("Has aprobado todo");
        }
        else if (nota1 < 5 && nota2 < 5 && nota3 < 5)
        {
            Console.WriteLine("Has suspendido todo");
        }
        else
        {
            Console.WriteLine("Has aprobado unas cosas y suspendido otras");
        }
    }
}


