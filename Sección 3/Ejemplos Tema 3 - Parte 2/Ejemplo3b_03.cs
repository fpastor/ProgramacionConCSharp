/*
 * Programa que usa un tipo enumerado (enum) para representar los
 * meses del año, e indicar cuántos días tiene el mes indicado por
 * el usuario.
 * 
 * Por Nacho Iborra
 */ 
 
using System;

public class Ejemplo
{
	enum meses { ENERO = 1, FEBRERO, MARZO, ABRIL, MAYO, JUNIO, JULIO,
				 AGOSTO, SEPTIEMBRE, OCTUBRE, NOVIEMBRE, DICIEMBRE };
				 
    static void Main()
    {
		int mes;
		
		Console.WriteLine("Introduce el mes (1 al 12):");
		mes = Convert.ToInt32( Console.ReadLine() );
		
		switch(mes)
		{
			case (int)meses.ENERO:
			case (int)meses.MARZO:
			case (int)meses.MAYO:
			case (int)meses.JULIO:
			case (int)meses.AGOSTO:
			case (int)meses.OCTUBRE:
			case (int)meses.DICIEMBRE: 
				Console.WriteLine("31 días"); break;
			case (int)meses.ABRIL:
			case (int)meses.JUNIO:
			case (int)meses.SEPTIEMBRE:
			case (int)meses.NOVIEMBRE:
				Console.WriteLine("31 días"); break;
			case (int)meses.FEBRERO:
				Console.WriteLine("28 o 29 días"); break;
			default:
				Console.WriteLine("Mes incorrecto"); break;
		}
    }
}


