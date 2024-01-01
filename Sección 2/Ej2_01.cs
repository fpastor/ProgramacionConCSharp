/*
 * Programa que muestra el mayor de dos números enteros
 * introducidos por el usuario 
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        int num1, num2;
        
        Console.WriteLine("Introduce el primer número:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce el segundo número:");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        if (num1 > num2)
        {
            Console.WriteLine("El mayor es {0}", num1);
        }
        else
        {
            Console.WriteLine("El mayor es {0}", num2);
        }
    }
}


