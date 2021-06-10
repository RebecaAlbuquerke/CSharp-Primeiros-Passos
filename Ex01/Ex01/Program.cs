using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite quantos quartos tem na sua casa");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do produto");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu ultimo nome, idade e altura. Separado por ' ' ");
            string[] vet = Console.ReadLine().Split(' ');

            string a = vet[0];
            int b = int.Parse(vet[1]);
            double c = double.Parse(vet[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(a + ' ' + b + ' ' + c);
        }
    }
}
