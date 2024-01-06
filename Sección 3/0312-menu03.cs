using System;

class Menu01
{
    enum opciones { SALIR, JUGAR, GUARDAR, CARGAR };
    static void Main()
    {
        Console.WriteLine( (int) opciones.JUGAR + ". Jugar");
        Console.WriteLine( (int) opciones.CARGAR + ". Cargar");
        Console.WriteLine( (int) opciones.SALIR + ". Salir");

        byte opcion = Convert.ToByte(Console.ReadLine());

        switch (opcion)
        {
            case (int) opciones.JUGAR: Console.WriteLine("Has escogido Jugar."); break;
            case (int) opciones.CARGAR: Console.WriteLine("Has escogido Cargar."); break;
            case (int) opciones.SALIR: Console.WriteLine("Has escogido Salir."); break;

            default: Console.WriteLine("Opción incorrecta"); break;
        }
    }
}
