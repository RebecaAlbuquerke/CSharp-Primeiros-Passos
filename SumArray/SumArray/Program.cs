﻿using System;
using System.Linq;

namespace SumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet = new double[6] { 1, 2, 3, 4, 10, 11 };

            //Usando For
            double sum = 0;
            for (int i = 0; i < 6; i++)
            {
                sum += vet[i];
            }
            Console.WriteLine(sum);

            //Usando Foreach
            double soma = 0;
            foreach (double elemento in vet)
            {
                soma += elemento;
            }
            Console.WriteLine(soma);

            //Usando linq
            double result = vet.Sum();
            Console.WriteLine(result);
        }
    }
}
