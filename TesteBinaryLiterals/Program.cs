using System;

namespace TesteBinaryLiterals
{
    class Program
    {
        private const int LETRA_Y_BIN = 0b01011001; // 01011001 (binário) = 89 (decimal)
        private const int LETRA_Z_BIN = 0B01011010; // 01011010 (binário) = 90 (decimal)

        static void Main(string[] args)
        {
            Console.WriteLine("Valor numérico de alguns caracteres ASCII");
            Console.WriteLine($"Y = {LETRA_Y_BIN}");
            Console.WriteLine($"Z = {LETRA_Z_BIN}");
            Console.ReadKey();
        }
    }
}