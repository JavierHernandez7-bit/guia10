using System;
using procesosA;

namespace ejercicio3Guia10
{
    class Principal
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            int[,] multi = new int[4, 3];
            int prom = 0;
            procesosA proc = new procesosA();
            Console.WriteLine("Esta es una amtriz de 4*3, rellenar con números enteros");
            multi = proc.Matriz();
            prom = proc.Promedio(multi);
            Console.Clear();
            Console.WriteLine($"El promedio de la matriz 4*3 es = {prom}");
            Console.ReadKey();
        }
    }
}