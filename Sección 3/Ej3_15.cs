/*
 * Programa que encripta y desencripta un texto utilizando
 * operaciones de bits, en concreto, XOR 2.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        string textoInicial, textoEncriptado = "", textoFinal = "";
        
        Console.WriteLine("Introduce el texto:");
        textoInicial = Console.ReadLine();
        
        foreach(char letra in textoInicial)
        {
            textoEncriptado += (char)(letra ^ 2);
        }
        
        Console.WriteLine(textoEncriptado);
        
        foreach(char letra in textoEncriptado)
        {
            textoFinal += (char)(letra ^ 2);
        }
        
        Console.WriteLine(textoFinal);
    }
}


