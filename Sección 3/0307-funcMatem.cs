using System;

class FuncMatematicas
{
    static void Main()
    {
        Console.Write("Dime un ángulo en grados: ");
        double anguloGrados = Convert.ToDouble(Console.ReadLine());
        double anguloRadianes = anguloGrados * Math.PI / 180.0;
        Console.WriteLine("El seno de {0} grados es: {1}",
            anguloGrados, Math.Sin(anguloRadianes));

        Console.Write("¿Qué raíz quieres hallar? ");
        Console.WriteLine( Math.Sqrt(Convert.ToDouble(Console.ReadLine()) ));
    }
}

