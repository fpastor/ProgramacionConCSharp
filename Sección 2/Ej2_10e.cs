/*
 * Programa que da al usuario 5 oportunidades para
 * adivinar una contraseña.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        int passwordUsuario, password = 1234, intentos = 5;
        
        do
        {
            Console.WriteLine("Introduce la contraseña:");
            passwordUsuario = Convert.ToInt32(Console.ReadLine());
            intentos--;
        }
        while(passwordUsuario != password && intentos > 0);
        
        if (passwordUsuario == password)
        {
            Console.WriteLine("Bienvenido/a");
        }
        else
        {
            Console.WriteLine("Has excedido el número de intentos.");
        }
    }
}


