/*
 * Programa que pide al usuario dos letras mayúsculas y muestra
 * la secuencia (creciente o decreciente) desde la primera hasta 
 * la segunda. Si alguno de los dos datos no es una letra mayúscula,
 * se le volverá a pedir al usuario hasta que lo sea.
 * 
 * Por Nacho Iborra
 */ 
 
using System;

public class Ejemplo
{    
    static void Main()
    {
		char letraInicio, letraFinal, letraActual;
		
		do
		{
			Console.WriteLine("Escribe una letra mayúscula:");
			letraInicio = Convert.ToChar( Console.ReadLine() );
			if (letraInicio < 'A' || letraInicio > 'Z')
				Console.WriteLine("Letra incorrecta");
		}
		while (letraInicio < 'A' || letraInicio > 'Z');

		do
		{
			Console.WriteLine("Escribe otra letra mayúscula:");
			letraFinal = Convert.ToChar( Console.ReadLine() );
			if (letraFinal < 'A' || letraFinal > 'Z')
				Console.WriteLine("Letra incorrecta");
		}
		while (letraFinal < 'A' || letraFinal > 'Z');
		
		letraActual = letraInicio;
		while (letraActual != letraFinal)
		{
			Console.Write("{0}", letraActual);
			if (letraInicio < letraFinal)
				letraActual++;
			else
				letraActual--;
		}
		Console.WriteLine(letraActual);

    }
}


