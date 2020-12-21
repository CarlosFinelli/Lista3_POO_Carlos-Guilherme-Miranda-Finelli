using System;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Insira um valor numérico: ");
                num[i] = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }
            Console.Write("Insira um valor qualquer entre 0 e 7: ");
            int x = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.Write($"Insira um valor qualquer entre 0 e 7: ");
            int y = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"A soma dos valores de posição {x} e {y} do vetor é: {num[x] + num[y]}");
            Console.ReadKey();
        }
    }
}
