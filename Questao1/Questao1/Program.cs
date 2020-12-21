using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Insira um número: ");
                num[i] = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
            }

            foreach(var item in num)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
