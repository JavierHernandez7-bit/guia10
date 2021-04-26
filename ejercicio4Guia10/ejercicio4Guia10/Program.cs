using System;
using txt;

namespace ejercicio4Guia10
{
    class Principal
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            String[] palabras = new String[3];
            int valid = 0;
            txt aText = new txt();
            palabras[0] = aText.Ingreso("primero");
            palabras[1] = aText.Ingreso("segundo");
            valid = string.Compare(palabras[0], palabras[1]);
            palabras[2] = aText.Estado(valid);
            Console.WriteLine($"Los textos son {palabras[2]}");
            Console.ReadKey();
        }
    }
}
