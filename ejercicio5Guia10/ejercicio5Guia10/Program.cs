using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ColecturiaAcad;
namespace ejercicio5Guia10
{
    class Principal
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            String[] palabras = new String[5];
            ColecturiaAcad wrd = new ColecturiaAcad();
            for (int x = 0; x < 4; x++)
            {
                palabras[x] = wrd.Palabra(x) + " ";
            }
            palabras[4] = string.Concat(palabras[0], palabras[1], palabras[2], palabras[3]);
            Console.WriteLine(palabras[4]);
            Console.ReadKey();
        }
    }
}