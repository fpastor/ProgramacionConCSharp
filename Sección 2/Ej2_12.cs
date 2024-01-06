/*
 * Programa que pide al usuario dos enteros a y b, y realiza el
 * cálculo de (a+b) / (a-b) controlando las posibles excepciones
 * que puedan producirse.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        int a, b;
        
        try
        {
            Console.WriteLine("Introduce el valor de a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el valor de b:");
            b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("{0}", (a+b)/(a-b));
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine("Error: No se puede dividir por cero.\n"  + e.Message);
        }
        catch(FormatException e)
        {
            Console.WriteLine("Error: Se esperaba un número entero.\n" + e.Message);
        }
    }
}


