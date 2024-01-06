/*
 * Programa que utiliza las variables de tipo implícito (var)
 * para pedir al usuario dos operandos y un operador, y
 * mostrar por pantalla la operación y su resultado.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        Console.WriteLine("Introduce el primer número:");
        var numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce el segundo número:");
        var numero2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce el operador:");
        var operador = Convert.ToChar(Console.ReadLine());
        
        var resultado = 0;
        var operacionPermitida = true;
        
        switch(operador)
        {
            case '+': resultado = numero1 + numero2; break;
            case '-': resultado = numero1 - numero2; break;
            case '*': resultado = numero1 * numero2; break;
            case '/': resultado = numero1 / numero2; break;
            default : operacionPermitida = false; break;
        }
        
        if (operacionPermitida)
        {
            Console.WriteLine("{0} {1} {2} = {3}",
                numero1, operador, numero2, resultado);
        }
        else
        {
            Console.WriteLine("Operación no permitida");
        }
    }
}


