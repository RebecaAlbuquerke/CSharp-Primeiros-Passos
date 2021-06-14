using System;
using System.Collections.Generic;
using System.Linq;

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

            //Usando For
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

            // Usando linq
            int contadora = 0;
            int contadorb = 0;
            var ab = a.Zip(b, (alice, bob) => (alice: alice, bob: bob));
            foreach (var rodada in ab)
            {
                if (rodada.alice > rodada.bob)
                {
                    contadora++;
                }
                else if (rodada.bob > rodada.alice)
                {
                    contadorb++;
                }
            }

            int[] vet = new int[2] { contadoralice, contadorbob };

            foreach (var pontuacao in vet)
            {
                Console.WriteLine(pontuacao);
            }


            var alicebob = a.Zip(b, (alice, bob) => (alice: alice, bob: bob)).Aggregate((alice: 0, bob: 0), (contador, rodada) =>
            {
                if (rodada.alice > rodada.bob)
                {
                    return (contador.alice + 1, contador.bob);
                }
                else if (rodada.bob > rodada.alice)
                {
                    return (contador.alice, contador.bob + 1);
                }
                else
                {
                    return contador;
                }
            });
        }
    }
}
