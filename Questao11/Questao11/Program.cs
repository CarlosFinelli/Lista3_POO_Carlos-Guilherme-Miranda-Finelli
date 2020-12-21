using System;

namespace Questao11
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[10];
            double soma = 0;
            int cont = 0;
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Insira o número {i} do vetor: ");
                num[i] = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }
            foreach(var item in num)
            {
                if (item > 0)
                {
                    soma += item;
                }
                if (item < 0)
                {
                    cont++;
                }
            }
            Console.WriteLine($"Soma dos números positivos no vetor: {soma}\n");
            Console.WriteLine($"Total de números negativos no vetor: {cont}");
            Console.ReadKey();
        }
    }
}
