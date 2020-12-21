using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[10];
            double[] armazena = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Insira o número {i} do vetor: ");
                num[i] = Convert.ToDouble(Console.ReadLine());
                armazena[i] = Math.Pow(num[i], 2);
                Console.Clear();
            }

            Console.WriteLine("Vetor normal: \n");
            foreach(var item in num)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nVetor com o quadrado dos números: \n");
            foreach(var item in armazena)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
