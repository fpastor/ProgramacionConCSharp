using System;
internal class Program
{
    static void Main()
    {
        char simbolo;

        Console.WriteLine("IDENTIFICADOR DE CARÁCTER");
        Console.WriteLine("");
        Console.Write("Introduce un símbolo: ");
        simbolo = Convert.ToChar(Console.ReadLine());

        switch (simbolo)
        {
            case ',':
            case '.':
            case ';':
            case ':': Console.WriteLine("Es un signo de puntuación");
            break;

            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9': Console.WriteLine("Es un dígito");
            break;

            default: Console.WriteLine("Es otra cosa");
            break;
        }

    }
}
