using LibreriaMatematica;
using System;

namespace Uguali3nmeri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il primo numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il terzo numero");
            int c = int.Parse(Console.ReadLine());

            bool r = Operazioni.Uguali(a, b, c);
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
