namespace JododeCorridadeDados.Consoleapp.Entidades;

using System.Security.Cryptography;

class Jogador
{
    public static int ExecutarRodada
    (
        int posicaoJogador,
        int limiteLinhaChegada,
        int bonusAvancoExtra,
        int penalidadeRecuo
    )
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Jogo dos Dados");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Rodada do Jogador");
        Console.WriteLine("--------------------------------------");

        Console.Write("Pressione ENTER para lançar um dado...");
        Console.ReadLine();

        int resultadoJogador = RandomNumberGenerator.GetInt32(1, 7);

        posicaoJogador += resultadoJogador;

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("O número sorteado foi: " + resultadoJogador);
        Console.WriteLine("--------------------------------------");

        Console.WriteLine($"Você está na posição: {posicaoJogador} de {limiteLinhaChegada}.");

        if (posicaoJogador == 5 || posicaoJogador == 10 || posicaoJogador == 15 || posicaoJogador == 25)
        {
            Console.WriteLine($"\nEvento: Avanço de {bonusAvancoExtra} casas!");

            posicaoJogador += bonusAvancoExtra;

            Console.WriteLine($"\nVocê está na posição: {posicaoJogador} de {limiteLinhaChegada}.");
        }

        else if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20)
        {
            Console.WriteLine($"\nEvento: Recuo de {penalidadeRecuo} casas!");

            posicaoJogador -= penalidadeRecuo;

            Console.WriteLine($"\nVocê está na posição: {posicaoJogador} de {limiteLinhaChegada}.");
        }

        return posicaoJogador;
    }

}
