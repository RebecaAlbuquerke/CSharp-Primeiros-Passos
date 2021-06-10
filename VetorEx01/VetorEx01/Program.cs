using System;
using System.Globalization;

namespace VetorEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho do vetor");
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                int c = i + 1;
                Console.WriteLine("Digite o " + c + "° numero");
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vet[i].ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
