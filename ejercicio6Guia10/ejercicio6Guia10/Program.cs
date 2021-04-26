using System;

namespace ejercicio6Guia10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            int cant = 0;
            String[] cadenas;
            Console.WriteLine("Digite la cantidad de palabras que desea alamacenar:");
            cant = int.Parse(Console.ReadLine());
            cadenas = new String[cant];
            for (int x = 0; x < cant; x++)
            {
                Console.Write($"Escriba el texto {x + 1}: ");
                cadenas[x] = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Normal:");
            for (int x = 0; x < cant; x++)
            {
                Console.WriteLine($"[{x + 1}]: {cadenas[x]}");
            }
            cadenas = Inversos(cant, cadenas);
            Console.WriteLine("Inverso:");
            for (int x = 0; x < cant; x++)
            {
                Console.WriteLine($"[{x + 1}]: {cadenas[x]}");
            }
            Console.ReadKey();
        }
        private static String[] Inversos(int num, String[] cad)
        {
            String[] resul = new String[num];
            for (int x = num - 1; x >= 0; x--)
            {
                resul[x] = cad[num - x - 1];
            }
            return resul;
        }
    }
}
