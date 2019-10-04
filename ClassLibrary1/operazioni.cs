using System;

namespace ClassLibrary1
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
            int d = a - b;
            return d;
        }
        public static double Divisione(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception("b == 0");
            }
            double f = a / b;
            return f;
        }
        public static double Moltiplicazione(double a, double b)
        {
            double m = a * b;
            return m;
        }
        public static double Potenza(double a, double b)
        {
            double p = 1;
            int c = 0;
            do
            {
                p = p * a;
                c++;
            } while (c < b);
            return p;
        }
        public static int Massimo(int a, int b)
        {
            if (a > b)
            {
                int max;
                max = a;
                return max;
            }
            else
            {
                int max;
                max = b;
                return max;
            }
        }
        public static int Minimo(int a, int b)
        {
            if (a < b)
            {
                int min;
                min = a;
                return min;
            }
            else
            {
                int min;
                min = b;
                return min;
            }

        }
    }
}
