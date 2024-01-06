using System;

class EncriptarXOR
{
    static void Main()
    {
        string frase = "Hola";

        foreach (char letra in frase)
        {
            char letra1 = (char)(letra ^ 1);
            Console.Write(letra1);
            char letra2 = (char)(letra1 ^ 1);
            Console.Write(letra2);
            Console.WriteLine();
        }
    }
}
