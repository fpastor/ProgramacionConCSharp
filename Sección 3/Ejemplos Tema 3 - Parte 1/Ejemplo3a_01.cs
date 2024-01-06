/*
 * Programa que pide al usuario dos datos de tipo "byte" y almacena
 * el producto de ambos en otra variable. También hace lo mismo con
 * dos datos enteros de 7 cifras.
 * 
 * Por Nacho Iborra
 */ 
 
using System;

public class Ejemplo
{    
    static void Main()
    {
        // Primera parte: producto de dos bytes
        
        byte numero1, numero2;
        int resultado;
        
        Console.WriteLine("Escribe dos números cortos (0-255):");
        numero1 = Convert.ToByte( Console.ReadLine() );
        numero2 = Convert.ToByte( Console.ReadLine() );
        
        resultado = numero1 * numero2;
        Console.WriteLine("El producto es {0}", resultado);
        
        // Segunda parte: producto de enteros de 7 cifras
        
        int numeroEntero1 = 1000000, numeroEntero2 = 2000000, resultadoEntero;
        
        resultadoEntero = numeroEntero1 * numeroEntero2;
        Console.WriteLine("El producto es {0}", resultadoEntero);
    }
}


