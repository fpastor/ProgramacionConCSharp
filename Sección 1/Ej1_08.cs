/*
 * Programa que muestra la tabla de multiplicar del número
 * introducido por el usuario 
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        int numero;
        
        Console.WriteLine("Introduce el número a multiplicar:");
        numero = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("{0} x {1} = {2}", numero, 0, numero * 0);
        Console.WriteLine("{0} x {1} = {2}", numero, 1, numero * 1);
        Console.WriteLine("{0} x {1} = {2}", numero, 2, numero * 2);
        Console.WriteLine("{0} x {1} = {2}", numero, 3, numero * 3);
        Console.WriteLine("{0} x {1} = {2}", numero, 4, numero * 4);
        Console.WriteLine("{0} x {1} = {2}", numero, 5, numero * 5);
        Console.WriteLine("{0} x {1} = {2}", numero, 6, numero * 6);
        Console.WriteLine("{0} x {1} = {2}", numero, 7, numero * 7);
        Console.WriteLine("{0} x {1} = {2}", numero, 8, numero * 8);
        Console.WriteLine("{0} x {1} = {2}", numero, 9, numero * 9);
        Console.WriteLine("{0} x {1} = {2}", numero, 10, numero * 10);
    }
}


