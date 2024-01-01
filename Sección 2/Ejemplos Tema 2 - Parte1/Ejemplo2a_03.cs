/*
 * Programa que le pide al usuario que introduzca un símbolo
 * o carácter suelto, e identifica si dicho símbolo es un 
 * signo de puntuación, un dígito o cualquier otra cosa.
 * 
 * Por Nacho Iborra
 */ 
 
using System;

public class Ejemplo
{    
    static void Main()
    {
        char simbolo;
        
        Console.WriteLine("Escribe un carácter:");
        simbolo = Convert.ToChar( Console.ReadLine() );
        
        switch(simbolo)
        {
            case ',':
            case '.':
            case ';':
            case ':': Console.WriteLine("Signo de puntuación"); break;
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9': Console.WriteLine("Dígito"); break;
            default: Console.WriteLine("Es otra cosa"); break;
        }
    }
}


