using System;

internal class Program
{
    static void Main()
    {
        int nota1, nota2, nota3;

        Console.WriteLine("NOTAS");
        Console.WriteLine("");
        Console.Write("Introduce la primera nota: ");
        nota1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce la segunda nota: ");
        nota2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce la tercera nota: ");
        nota3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        if (nota1 >= 5 && nota2 >=5 && nota3 >= 5)
        {
            Console.WriteLine("Has aprobado todo");
        }
        else if (nota1 < 5 && nota2 < 5 && nota3 < 5)
        {
            Console.WriteLine("Has suspendido todo");
        }
        else
        {
            Console.WriteLine("Has aprobado unas cosas y suspendido otras");
        }
    }
}


