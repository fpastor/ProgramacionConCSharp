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
        else if (nivel == 2)
            puntos = 20;
        else
            puntos = 30;
            
        Console.WriteLine("Puntos: {0}", puntos);
        
        puntos = nivel == 1 ? 10 : ( nivel == 2 ? 20 : 30 );
            
        Console.WriteLine("Puntos: {0}", puntos);
    }
}

