/*
 * Programa que muestra el mayor de tres números enteros
 * introducidos por el usuario 
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        int num1, num2, num3;
        
        Console.WriteLine("Introduce el primer número:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce el segundo número:");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce el tercer número:");
        num3 = Convert.ToInt32(Console.ReadLine());
        
        if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine("El mayor es {0}", num1);
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            Console.WriteLine("El mayor es {0}", num2);
        }
        else
        {
            Console.WriteLine("El mayor es {0}", num3);
        }
    }
}


