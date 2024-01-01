using System;

class NombreDeUnMes
{
    static void Main()
    {
        int mes;

        Console.Write("Dime un mes: ");
        mes = Convert.ToInt32( Console.ReadLine() );
            
        switch( mes )
        {
            case 1 :
            case 2 :
                Console.WriteLine("Enero o Febrero");
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

