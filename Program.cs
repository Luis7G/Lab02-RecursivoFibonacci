using System;
using System.Diagnostics;
namespace Lab02_RecursivoFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch Temporizador = new Stopwatch();
            Program myobject = new Program();
            int n=0, k;
            do
            {
                Console.WriteLine("Introduzca el número de términos: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 1);
            Temporizador.Start();
            Console.WriteLine("\tSerie números de fibonacci recursivo: ");
            for (k = 0; k < n; k++)
            {
                Console.Write(myobject.FibonacciRecursivo(k)+" ");
            }
            Temporizador.Stop();
            Console.WriteLine("\n->El programa recursivo se ejecutó en  "+Temporizador.ElapsedMilliseconds+" ms");
            Temporizador.Start();
            Console.WriteLine("\n\tSerie números de fibonacci iterativo: ");
            myobject.FibonacciIterativo(n);
            Temporizador.Stop();
            Console.WriteLine("\n->El programa iterativo se ejecutó en  "+Temporizador.ElapsedMilliseconds+" ms");
        }
        long FibonacciRecursivo(int n)
        {
            if (n < 2) { return n; }
            else { return FibonacciRecursivo(n - 2) + FibonacciRecursivo(n - 1); }
        }
        void FibonacciIterativo(int n)
        {
            int i; long ant1, ant2;
            ant1 = ant2 = 1;
            Console.Write("0 1 1 ");
            for (i = 1; i < n - 2; i++)
            {
                long actual = ant1 + ant2;
                Console.Write(actual+" ");
                ant2 = ant1;
                ant1 = actual;
            }
        }
    }
}