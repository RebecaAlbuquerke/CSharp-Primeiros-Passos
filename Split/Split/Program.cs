using System;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 frutas separado por espaço ' ' ");
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }
}
