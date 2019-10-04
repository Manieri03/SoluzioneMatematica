using System;

namespace LibreriaMatematica
{
    public class Operazioni
    {
        public static int Somma(int a, int b)
        {
            int s = a + b;
            return s;
        }
        public static int Sottrazione(int a, int b)
        {
            int st = a - b;
            return st;
        }
        public static int Moltiplicazione(int a, int b)
        {
            int m = a*b;
            return m;
        }
        public static double Divisione(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception("La divisione per 0 non è valida");

            }
            double d = a / b;
            return d;
        }

        public static double Potenza(double a, int b)
        {
            int c = 1;
            while (c < b)
            {
                c = c + 1;
                a = a * a;


            }
            return a;
        }

        public static double Max(double a, double b)
        {
            double Mx;
            if (a >= b)
            {
                Mx = a;

            }
            else 
            {
                Mx = b;

            }
            return Mx;

        }

    }
}
