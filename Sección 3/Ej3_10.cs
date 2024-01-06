/*
 * Programa que simula un traductor sencillo de C# a Java, identificando 
 * una serie de instrucciones sencillas y mostrando su equivalente en Java.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        string instruccion;
        
        Console.WriteLine("Escribe la instrucción en lenguaje C#:");
        instruccion = Console.ReadLine();
        
        // if .. else
        
        if (instruccion == "if" || instruccion == "while" || instruccion == "for")
        {
            Console.WriteLine("En Java es: {0}", instruccion);
        }
        else if (instruccion == "Console.WriteLine")
        {
            Console.WriteLine("En Java es: System.out.println");
        }
        else
        {
            Console.WriteLine("Orden no reconocida");
        }
        
        // switch
        
        switch(instruccion)
        {
            case "if":
            case "while":
            case "for": 
                Console.WriteLine("En Java es: {0}", instruccion); break;
            case "Console.WriteLine":
                Console.WriteLine("En Java es: System.out.println"); break;
            default:
                Console.WriteLine("Orden no reconocida"); break;
        }
    }
}


