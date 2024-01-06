// Ejemplo de "goto" para interrumpir dos bucles anidados

using System;

class ForBreak 
{
    static void Main() 
    {
        for(int j = 1; j < 5; j++)
        {
            for(int i = 1; i <= 10; i++)
            {
                if (i == 5)
                    goto fin;
                
                Console.WriteLine( i );
            }
        }
        
        fin :
        Console.WriteLine("Adios");
    }
}

