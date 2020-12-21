using System;

namespace Questao8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[6];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Insira um número inteiro: ");
                num[i] = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("Vetor na ordem inversa: \n");
            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadKey();
        }
    }
}
