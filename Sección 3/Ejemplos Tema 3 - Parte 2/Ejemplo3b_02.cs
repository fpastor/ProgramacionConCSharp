/*
 * Programa que pide al usuario 5 números enteros, e indica si alguno
 * de los números introducidos es impar.
 * 
 * Por Nacho Iborra
 */ 
 
using System;

public class Ejemplo
{    
    static void Main()
    {
		const int TOTAL_NUMEROS = 5;
		int numeroActual;
		bool hayNumeroImpar = false;
		
		Console.WriteLine("Escribe {0} números:", TOTAL_NUMEROS);
		for (int i = 0; i < TOTAL_NUMEROS; i++)
		{
			numeroActual = Convert.ToInt32( Console.ReadLine() );
			if (numeroActual % 2 != 0)
				hayNumeroImpar = true;
		}
		
		if (hayNumeroImpar)
			Console.WriteLine("Has escrito algún número impar");
		else
			Console.WriteLine("No has escrito ningún número impar");
    }
}


