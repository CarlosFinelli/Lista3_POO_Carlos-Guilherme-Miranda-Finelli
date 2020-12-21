using System;

namespace Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Insira um número: ");
                num[i] = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
            }
            int Maior = 0, posicao = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > Maior)
                {
                    Maior = num[i];
                    posicao = i;
                }
            }
            foreach(var item in num)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine($"Maior elemento: {Maior} | Posição: {posicao}");
            Console.ReadKey();
        }
    }
}
