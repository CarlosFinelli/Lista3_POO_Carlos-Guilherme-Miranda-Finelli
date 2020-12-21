using System;
using System.Linq;

namespace Questao13
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num1 = new double[5];
            double maior1 = 0, menor1 = 0, media1 = 0;
            int maiorP1 = 0, menorP1 = 0;

            for (int i = 0; i < num1.Length; i++)
            {
                Console.Write($"Insira o número {i} do vetor 1: ");
                num1[i] = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }
            menor1 = num1.Last();
            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] > maior1)
                {
                    maior1 = num1[i];
                    maiorP1 = i;
                }
                if (num1[i] <= menor1)
                {
                    menor1 = num1[i];
                    menorP1 = i;
                }
                media1 += num1[i];
            }
            Console.WriteLine("Valores do vetor: \n");
            foreach (var item in num1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine($"Maior número do vetor: {maior1} | Posição no vetor: {maiorP1}\n");
            Console.WriteLine($"Menor número do vetor: {menor1} | Posição no vetor: {menorP1}\n");
            Console.WriteLine($"Média dos valores do vetor: {media1 / num1.Length}\n\n");
            Console.ReadKey();
        }
    }
}
