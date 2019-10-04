using System;
using LibreriaMatematica;

namespace Matematica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il primo numero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Che operazione vuoi fare? (A/S/M/D/P/Max)");
            string risposta = Console.ReadLine();

            
            double risultato;
            if (risposta == "A")
                risultato = Operazioni.Somma(n1, n2);
            else if (risposta == "S")
                risultato = Operazioni.Sottrazione(n1, n2);
            else if (risposta == "M")
                risultato = Operazioni.Moltiplicazione(n1, n2);
            else if (risposta == "D")
                try
                {
                    risultato = Operazioni.Divisione(n1, n2);
                }catch(Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    risultato = double.NaN;
                }
            else if (risposta == "P")
            {
                risultato = Operazioni.Potenza(n1, n2);
            }
            else if (risposta == "M")
            {
                risultato = Operazioni.Max(n1, n2);
            }


            else
                risultato = double.NaN;

            Console.WriteLine(risultato);
            Console.ReadLine();


            int somma = Operazioni.Somma(n1, n2);
            Console.WriteLine(somma);
            

            int sottrazione = Operazioni.Sottrazione(n1, n2);
            Console.WriteLine(sottrazione);
            

            int moltiplicazione = Operazioni.Moltiplicazione(n1, n2);
            Console.WriteLine(moltiplicazione);
            

            double divisione = Operazioni.Divisione(n1, n2);
            Console.WriteLine(divisione);
            Console.ReadLine();

            double potenza = Operazioni.Potenza(n1, n2);
            Console.WriteLine(potenza);
            Console.ReadLine();

            double max = Operazioni.Max(n1, n2);
            Console.WriteLine(max);
            Console.ReadLine();


        }
    }
}
