// Alternativa a "continue" para saltar "una pasada" un bucle

using System;

class ForContinue2
{
    static void Main() 
    {
        for(int i = 1; i <= 10; i++)
        {
            if (i != 5)
                Console.WriteLine( i );
        }
    }
}

