/*
 * Programa que le pide al usuario un número de día
 * de la semana y le muestra a qué día corresponde.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        int dia;
        
        Console.WriteLine("Introduce el número de día:");
        dia = Convert.ToInt32(Console.ReadLine());
        
        switch(dia)
        {
            case 1:
                Console.WriteLine("Es LUNES");
                break;
            case 2:
                Console.WriteLine("Es MARTES");
                break;
            case 3:
                Console.WriteLine("Es MIÉRCOLES");
                break;
            case 4:
                Console.WriteLine("Es JUEVES");
                break;
            case 5:
                Console.WriteLine("Es VIERNES");
                break;
            case 6:
                Console.WriteLine("Es SÁBADO");
                break;
            case 7:
                Console.WriteLine("Es DOMINGO");
                break;
            default:
                Console.WriteLine("Número de día es incorrecto.");
                break;
        }
    }
}


