/*
 * Programa que simula el comportamiento básico de un videojuego: pide al usuario
 * el número de vidas restantes y el nivel actual, y en función de esos datos
 * decide si se ha terminado la partida.
 * 
 * Por Nacho Iborra
 */ 

using System;

public class Ejercicio
{    
    static void Main()
    {
        int numeroVidas, nivelActual;
        bool quedanVidas, juegoCompletado, partidaTerminada;
        
        do
        {
            Console.WriteLine("Introduce las vidas restantes:");
            numeroVidas = Convert.ToInt32(Console.ReadLine());
            quedanVidas = numeroVidas > 0;
            
            Console.WriteLine("Introduce el nivel actual:");
            nivelActual = Convert.ToInt32(Console.ReadLine());  
            juegoCompletado = nivelActual == 11;
            
            partidaTerminada = !quedanVidas || juegoCompletado;          
        }
        while(!partidaTerminada);
    }
}


