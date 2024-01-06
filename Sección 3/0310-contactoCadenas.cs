using System;

class Cadenas1
{
    static void Main()
    {
        string nombre;
        Console.WriteLine("Dime tu nombre");
        nombre = Console.ReadLine();
        if (nombre == "Nacho")
            Console.WriteLine("Hola, " + nombre);
        else
            Console.WriteLine("Hola, desconocido");
    }
}

