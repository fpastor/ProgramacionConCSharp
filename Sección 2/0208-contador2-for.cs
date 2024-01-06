using System;

class While1 
{
    static void Main() 
    {
        int i = 10;
        while (i <= 16)  
        {
            Console.WriteLine( i );
            i++;
        }
        
        for(int n = 10; n <= 16; n++)
        {
            Console.WriteLine( n );
        }
    }
}

