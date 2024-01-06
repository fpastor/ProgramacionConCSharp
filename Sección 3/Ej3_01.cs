/*
 * Programa que pide al usuario tres datos enteros: su año
 * de nacimiento, su edad y la población de su país, para practicar
 * con distintos tipos de datos enteros.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        ushort anyoNacimiento;
        byte edad;
        ulong poblacion;
        
        Console.WriteLine("Introduce tu año de nacimiento:");
        anyoNacimiento = Convert.ToUInt16( Console.ReadLine() );
        Console.WriteLine("Introduce tu edad:");
        edad = Convert.ToByte( Console.ReadLine() );
        Console.WriteLine("Introduce la población de tu país:");
        poblacion = Convert.ToUInt64( Console.ReadLine() );
        
        Console.WriteLine("Has nacido en {0}", anyoNacimiento);
        Console.WriteLine("Tienes {0} años", edad);
        Console.WriteLine("Tu país tiene {0} habitantes", poblacion);
        
    }
}


