using System;

class NombreDeUnMes
{
    static void Main()
    {
        int mes;

        Console.Write("Dime un mes: ");
        mes = Convert.ToInt32( Console.ReadLine() );

        if ( mes == 1 )
            Console.WriteLine("Enero");
        else if ( mes == 2 )
            Console.WriteLine("Febrero");
        else if ( mes == 3 )
            Console.WriteLine("Marzo");
        else
            Console.WriteLine("No sé cual es");
            
        switch( mes )
        {
            case 1 :
                Console.WriteLine("Enero");
                break;
            case 2 :
                Console.WriteLine("Febrero");
                break;
            case 3 :
                Console.WriteLine("Marzo");
                break;
            default :
                Console.WriteLine("No sé cual es");
                break;
        }
    }
}

