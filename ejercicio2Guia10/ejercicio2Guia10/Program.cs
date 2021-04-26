using System;
using System.Linq;

namespace ejercicio2Guia10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            int filas = 0, columnas = 0, max = 0, min = 0, ints = 0;
            int[] matriz;
            Console.Write("Escriba la cantidad de filas de la matriz que desea: ");
            filas = int.Parse(Console.ReadLine());
            Console.Write("\nEscriba la cantidad de columnas de la matriz que desea: ");
            columnas = int.Parse(Console.ReadLine());
            ints = filas * columnas;
            matriz = new int[ints];
            for (int x = 0; x < filas; x++)
            {
                for (int y = 0; y < columnas; y++)
                {
                    Console.Write($"Ingrese el valor [{x + 1}, {y + 1}]: ");
                    matriz[y] = int.Parse(Console.ReadLine());
                }
            }
            max = matriz.Max();
            min = matriz.Min();
            Console.Clear();
            Console.WriteLine($"" +
                $"El mayor número de la matriz es: {max}\n" +
                $"El mayor número de la matriz es: {min}");
            Console.ReadKey();

        }
    }
}