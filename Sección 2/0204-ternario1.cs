using System;

class Puntos
{
    static void Main()
    {
        int nivel, puntos;

        Console.Write("Dime el nivel: ");
        nivel = Convert.ToInt32( Console.ReadLine() );
            
        if (nivel == 1)
            puntos = 10;
        else
            puntos = 30;
            
        Console.WriteLine("Puntos: {0}", puntos);
        
        puntos = nivel == 1 ? 10 : 20;
            
        Console.WriteLine("Puntos: {0}", puntos);
    }
}

