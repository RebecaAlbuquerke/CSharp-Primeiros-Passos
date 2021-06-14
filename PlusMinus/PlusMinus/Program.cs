using System;
using System.Collections.Generic;
using System.Linq;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { -4, 3, -9, 0, 4, 1 };


            double quantidadepositivos = 0;
            double quantidadenegativos = 0;
            double quantidadezeros = 0;
            int n = arr.Count;
            foreach (int elemento in arr)
            {
                if (elemento > 0)
                {
                    quantidadepositivos++;
                }
                if (elemento < 0)
                {
                    quantidadenegativos++;
                }
                if (elemento == 0)
                {
                    quantidadezeros++;
                }
            }

            double proporcaopositiva = (quantidadepositivos / n);
            double proporcaonegativa = (quantidadenegativos / n);
            double proporcaozero = (quantidadezeros / n);

            Console.WriteLine(proporcaopositiva.ToString("F6"));
            Console.WriteLine(proporcaonegativa.ToString("F6"));
            Console.WriteLine(proporcaozero.ToString("F6"));
        }
    }
}
