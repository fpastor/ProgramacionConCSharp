/*
 * Programa que le pide al usuario una contraseña
 * numérica repetidamente, hasta que introduzca
 * "1234". Se utiliza una estructura do-while.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        int password;
        
        do
        {
            Console.WriteLine("Introduce la contraseña:");
            password = Convert.ToInt32(Console.ReadLine());
        }
        while(password != 1234);
        
        Console.WriteLine("Bienvenido/a");
    }
}


