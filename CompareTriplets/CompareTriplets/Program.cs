using System;
using System.Collections.Generic;

namespace CompareTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3] { 17, 28, 30 };
            int[] b = new int[3] { 99, 16, 8 };

            int contadoralice = 0;
            int contadorbob = 0;

            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                {
                    contadoralice++;
                }
                if (b[i] > a[i])
                {
                    contadorbob++;
                }
            }

            int[] vet = new int[2] { contadoralice, contadorbob };

            foreach (var pontuacao in vet)
            {
                Console.WriteLine(pontuacao);
            }
        }
    }
}
