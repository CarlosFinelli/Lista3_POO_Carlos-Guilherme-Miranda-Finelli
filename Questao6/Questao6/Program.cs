using System;
using System.Linq;

namespace Questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[10];
            double maior = 0, menor;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Insira um número: ");
                num[i] = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }
            menor = num.Last();
            foreach(var item in num)
            {
                if (item > maior)
                {
                    maior = item;
                }
                if (item < menor)
                {
                    menor = item;
                }
            }
            Console.WriteLine($"Maior item do vetor: {maior}\n");
            Console.WriteLine($"Menor item do vetor: {menor}");
            Console.ReadKey();
        }
    }
}
