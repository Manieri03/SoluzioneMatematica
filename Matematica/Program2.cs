using LibreriaMatematica;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matematica
{
    class Program2
    {
        private static int risposta;

        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il primo numero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Che operazione vuoi fare? (A/S/M/D/P/Max)");
            string risposta = Console.ReadLine();
            double risultato=0;
            switch (risposta)
            {
                

                case "A":
                    risultato = Operazioni.Somma(n1, n2);
                    break;
                case "S":
                    risultato = Operazioni.Sottrazione(n1, n2);
                    break;
                case "M":
                    risultato = Operazioni.Moltiplicazione(n1, n2);
                    break;
                case "D":
                    risultato = Operazioni.Divisione(n1, n2);
                    break;
                case "P":
                    risultato = Operazioni.Potenza(n1, n2);
                    break;
                case "Max":
                    risultato = Operazioni.Max(n1, n2);
                    break;
            }Console.WriteLine(risultato);
            Console.ReadLine();

        }
    }
}


            