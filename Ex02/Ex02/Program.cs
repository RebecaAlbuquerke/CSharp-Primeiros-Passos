using System;
using System.Globalization;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura = 10.0;
            double comprimento = 30.0;
            double valorMetroQuadrado = 200.00;

            double area = largura * comprimento;
            double preco = area * valorMetroQuadrado;

            Console.WriteLine("area: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("preco: " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
