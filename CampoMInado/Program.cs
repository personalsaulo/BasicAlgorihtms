using System;

namespace CampoMInado
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;

            const int qtdBombas = 10;
            const int quantidadeJogadas = 10;
            char[,] campo = new char[n, n];

            Random mistura = new Random();
            for (int i = 0; i < qtdBombas; i++)
            {
                int linha = mistura.Next(0, n - 1);
                int coluna = mistura.Next(0, n - 1);

                campo[linha, coluna] = 'B';

            }

            //Jogo
            int pontuacao = 0;
            for (int jogada = 0; jogada < quantidadeJogadas; jogada++)
            {
                Console.WriteLine("Qual linha?");
                int linha = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual coluna?");
                int coluna = int.Parse(Console.ReadLine());

                if (campo[linha, coluna] != 'B')
                {
                    pontuacao++;
                    Console.WriteLine("Sem bomba! Pontuacao = " + pontuacao);
                    campo[linha, coluna] = 'B';
                }
                else
                {
                    Console.WriteLine("Voce MORREU! Pontuacao total = " + pontuacao);
                    break;
                }
            }

            if (pontuacao == quantidadeJogadas)
                Console.WriteLine("VOCE GANHOU!!");

            Console.ReadLine();
        }
    }
}
