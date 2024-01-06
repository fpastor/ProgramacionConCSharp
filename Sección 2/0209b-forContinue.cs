// Ejemplo de "continue" para saltar "una pasada" un bucle

using System;

class ForContinue 
{
    static void Main() 
    {
        for(int i = 1; i <= 10; i++)
        {
            if (i == 5)
                continue;
            
            Console.WriteLine( i );
        }
    }
}

