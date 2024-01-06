// Ejemplo de "break" para interrumpir un bucle

using System;

class ForBreak 
{
    static void Main() 
    {
        for(int i = 1; i <= 10; i++)
        {
            if (i == 5)
                break;
            
            Console.WriteLine( i );
        }
    }
}

