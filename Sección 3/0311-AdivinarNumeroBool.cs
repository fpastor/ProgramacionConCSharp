using System;

class AdivinarUnNumero
{
    static void Main()
    {
        int oculto, n;
        int maxIntentos = 9, intentoActual = 0;
        bool acertado, quedanIntentos;

        oculto = DateTime.Now.Millisecond;
        do
        {
            Console.Write("Dime un número del 0 al 999: ");
            n = Convert.ToInt32(Console.ReadLine());

            acertado = n == oculto;

            if (n == oculto)
                Console.WriteLine("¡Acertaste!");
            else if (n > oculto)
                Console.WriteLine("Te has pasado");
            else
                Console.WriteLine("Te has quedado corto");

            intentoActual++;

            quedanIntentos = intentoActual < maxIntentos;

            Console.WriteLine("Intento restantes: {0}",
                maxIntentos - intentoActual);
        }
        while ( ! acertado && quedanIntentos);

        if ( ! acertado )
            Console.WriteLine("¡Lo siento! Era {0}", oculto);
    }
}
