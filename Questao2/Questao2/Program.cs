using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[6];
            num[0] = 1;
            num[1] = 0;
            num[2] = 5;
            num[3] = -2;
            num[4] = -5;
            num[5] = 7;

            int soma = num[0] + num[1] + num[5];
            Console.WriteLine(soma);
            Console.WriteLine();

            num[4] = 100;
            foreach(var item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}
