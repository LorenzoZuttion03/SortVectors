using System;

namespace SortVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10] { 4, -1, 100, 85, 4, 6, 77, 35, 2, 0 };

            Ordina(vet);

            int min = Minimo(vet);
            Console.WriteLine("Il valore minimo è: " + min);

            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(vet[i]);
            }

            Console.ReadKey();
        }
        static void Ordina(int[] v)
        {
            Array.Sort(v);
        }

        static int Minimo(int[] v)
        {
            return v[0];
        }
    }
}
