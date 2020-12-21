using System;

namespace Questao10
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[15];
            double media = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Insira a nota do aluno {i}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                media += notas[i];
            }
            Console.WriteLine($"Média das notas dos alunos: {media / notas.Length}");
            Console.ReadKey();
        }
    }
}
