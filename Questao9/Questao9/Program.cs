using System;

namespace Questao9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[6];
            for (int i = 0; i < num.Length; i++)
            {
                Inicio:
                Console.Write("Insira um número inteiro par: ");
                num[i] = Convert.ToInt16(Console.ReadLine());
                if (num[i] % 2 != 0)
                {
                    Console.WriteLine("Número não é par.");
                    Console.ReadKey();
                    Console.Clear();
                    goto Inicio;
                }
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
