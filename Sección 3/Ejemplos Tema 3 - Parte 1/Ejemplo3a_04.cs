/*
 * Programa que calcula las posibles soluciones de una
 * ecuación de segundo grado.
 * 
 * Por Nacho Iborra
 */ 
 
using System;

public class Ejemplo
{    
    static void Main()
    {
        int a, b, c;
        float x1, x2;
        
        Console.WriteLine("Introduce los valores de a, b y c:");
        a = Convert.ToInt32( Console.ReadLine() );
        b = Convert.ToInt32( Console.ReadLine() );
        c = Convert.ToInt32( Console.ReadLine() );
        
        if (a == 0)
        {
            // Ecuación de primer grado
            
            if (b == 0)
            {
                if (c == 0)
                {
                    // Identidad (0 = 0)
                    Console.WriteLine("Identidad (0 = 0)");
                }
                else
                {
                    // Solución imposible (0 = !0)
                    Console.WriteLine("Solución imposible");
                }
            }
            else
            {
                // Solución x = -c / b
                x1 = -c / (float)b;
                Console.WriteLine("x = {0}", x1.ToString("0.#"));
            }
        }
        else
        {
            // Ecuación de segundo grado
            
            float discriminante = b * b - 4 * a * c;
            
            if (discriminante < 0)
            {
                // No hay soluciones reales (raíz negativa)
                Console.WriteLine("No existen soluciones reales");
            }
            else
            {
                x1 = (-b + (float)Math.Sqrt(discriminante)) / (2 * a);
                x2 = (-b - (float)Math.Sqrt(discriminante)) / (2 * a);
                
                Console.WriteLine("x1 = {0}", x1.ToString("0.#"));
                Console.WriteLine("x2 = {0}", x2.ToString("0.#"));
            }
        }
    }
}


