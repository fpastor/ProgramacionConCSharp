// Ejemplo de "goto" para interrumpir un bucle

using System;

class ForGoto
{
    static void Main() 
    {
        for(int i = 1; i <= 10; i++)
        {
            if (i == 5)
                goto fin;
            
            Console.WriteLine( i );
        }
        
        fin :
        Console.WriteLine("Adios");
    }
}

