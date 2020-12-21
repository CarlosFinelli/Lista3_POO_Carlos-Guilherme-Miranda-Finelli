using System;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[10];
            int cont = 0;
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Insira um valor numérico: ");
                num[i] = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("Números pares no vetor: \n");
            foreach(var item in num)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                    cont++;
                }
            }
            Console.WriteLine($"\nTotal de números pares no vetor: {cont}");
            Console.ReadKey();
        }
    }
}
