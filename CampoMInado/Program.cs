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
        }
    }
}
