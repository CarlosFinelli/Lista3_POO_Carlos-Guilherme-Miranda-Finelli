using System;
using System.Linq;

namespace Questao12
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num1 = new double[5];
            double maior1 = 0, menor1 = 0, media1 = 0;

            for (int i = 0; i < num1.Length; i++)
            {
                Console.Write($"Insira o número {i} do vetor 1: ");
                num1[i] = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }

            menor1 = num1.Last();
            foreach (var item in num1)
            {
                if (item > maior1)
                {
                    maior1 = item;
                }
                if (item < menor1)
                {
                    menor1 = item;
                }
                media1 += item;
            }

            Console.WriteLine("Valores do vetor: \n");
            foreach(var item in num1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine($"Maior número do vetor: {maior1}\n");
            Console.WriteLine($"Menor número do vetor: {menor1}\n");
            Console.WriteLine($"Média dos valores do vetor: {media1 / num1.Length}\n\n");

            Console.ReadKey();
        }
    }
}
