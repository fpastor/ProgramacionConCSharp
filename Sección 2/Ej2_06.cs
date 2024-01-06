/*
 * Programa que le pide al usuario una contraseña
 * numérica repetidamente, hasta que introduzca
 * "1234".
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        int password = 0;
        
        while(password != 1234)
        {
            Console.WriteLine("Introduce la contraseña:");
            password = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("Bienvenido/a");
    }
}


