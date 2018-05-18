using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[] { 10, 0, 11, -1, 201, 13, 123 };


            for(int rodada=0; rodada<vetor.Length; rodada++)
            {
                for(int atual = 0; atual < vetor.Length-1; atual++)
                {
                    if(vetor[atual] > vetor[atual +1])
                    {
                        int troca = vetor[atual];
                        vetor[atual] = vetor[atual + 1];
                        vetor[atual + 1] = troca;
                    }
                }
            }

            for(int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }
            Console.ReadKey();
        }
    }
}
