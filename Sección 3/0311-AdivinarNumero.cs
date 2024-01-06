using System;

class AdivinarUnNumero
{
    static void Main()
    {
        int oculto, n;
        int maxIntentos = 9, intentoActual = 0;

        oculto = DateTime.Now.Millisecond;
        do
        {
            Console.Write("Dime un número del 0 al 999: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == oculto)
                Console.WriteLine("¡Acertaste!");
            else if (n > oculto)
                Console.WriteLine("Te has pasado");
            else
                Console.WriteLine("Te has quedado corto");
            
            intentoActual ++;
            Console.WriteLine("Intento restantes: {0}",
                maxIntentos - intentoActual);
        }
        while (n != oculto 
            && intentoActual < maxIntentos);
            
        if (n != oculto)
                Console.WriteLine("¡Lo siento! Era {0}", oculto);
    }
}
