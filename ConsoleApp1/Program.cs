using ClassLibrary1;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci due numeri");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int Somma = Operazioni.Somma(a, b);
            Console.WriteLine("la somma è:");
            Console.WriteLine(Somma);
            int Sottrazione = Operazioni.Sottrazione(a, b);
            Console.WriteLine("la sottrzione è:");
            Console.WriteLine(Sottrazione);
            double Divisione = Operazioni.Divisione(a, b);
            Console.WriteLine("la divisione è:");
            Console.WriteLine(Divisione);
            double Moltiplicazione = Operazioni.Moltiplicazione(a, b);
            Console.WriteLine("la moltiplicazione è:");
            Console.WriteLine(Moltiplicazione);
            double Potenza = Operazioni.Potenza(a, b);
            Console.WriteLine("la potenza è:");
            Console.WriteLine(Potenza);
            int Massimo = Operazioni.Massimo(a, b);
            Console.WriteLine("il max è:");
            Console.WriteLine(Massimo);
            int Minimo = Operazioni.Minimo(a, b);
            Console.WriteLine("il min è:");
            Console.WriteLine(Minimo);
            Console.ReadLine();

        }
    }
}
