namespace JododeCorridadeDados.Consoleapp;

using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        const int limiteLinhaChegada = 30;
        const int bonusAvancoExtra = 3;
        const int penalidadeRecuo = 2;

        while (true)
        {
            int posicaoJogador = 0;
            int posicaoComputador = 0;

            while (true)
            {
                // 1. Rodada do Jogador
                posicaoJogador = Jogador.ExecutarRodada(
                    posicaoJogador,
                    limiteLinhaChegada,
                    bonusAvancoExtra,
                    penalidadeRecuo
                );

                // 2. Check de vitória do Jogador
                ApresentarMensagemDoJogador(posicaoJogador, limiteLinhaChegada);

                if (posicaoJogador >= limiteLinhaChegada)
                    break;

                // 3. Rodada do Computador
                posicaoComputador = ExecutarRodadaDoComputador(
                    posicaoComputador,
                    limiteLinhaChegada,
                    bonusAvancoExtra,
                    penalidadeRecuo
                );

                // 4. Check de vitória do Computador
                ApresentarMensagemDoComputador(posicaoComputador, limiteLinhaChegada);

                if (posicaoComputador >= limiteLinhaChegada)
                    break;
            }

            Console.WriteLine("--------------------------------------");
            Console.Write("Deseja continuar? (s/N): ");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }


    static void ApresentarMensagemDoJogador(int posicaoJogador, int limiteLinhaChegada)
    {
        if (posicaoJogador >= limiteLinhaChegada)
        {
            Console.WriteLine($"Parabéns! Você alcançou a linha de chegada.");
            Console.WriteLine("--------------------------------------");
            Console.Write("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("--------------------------------------");
            Console.Write("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
    }

    static int ExecutarRodadaDoComputador
    (
        int posicaoComputador,
        int limiteLinhaChegada,
        int bonusAvancoExtra,
        int penalidadeRecuo
    )
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Jogo dos Dados");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Rodada do Computador");

        int resultadoComputador = RandomNumberGenerator.GetInt32(1, 7);

        posicaoComputador += resultadoComputador;

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("O número sorteado foi: " + resultadoComputador);
        Console.WriteLine("--------------------------------------");

        Console.WriteLine($"O computador está na posição: {posicaoComputador} de {limiteLinhaChegada}.");

        if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15 || posicaoComputador == 25)
        {
            Console.WriteLine($"\nEvento: Avanço de {bonusAvancoExtra} casas!");

            posicaoComputador += bonusAvancoExtra;

            Console.WriteLine($"\nO computador está na posição: {posicaoComputador} de {limiteLinhaChegada}.");
        }

        else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
        {
            Console.WriteLine($"\nEvento: Recuo de {penalidadeRecuo} casas!");

            posicaoComputador -= penalidadeRecuo;

            Console.WriteLine($"\nO computador está na posição: {posicaoComputador} de {limiteLinhaChegada}.");
        }

        return posicaoComputador;
    }

    static void ApresentarMensagemDoComputador(int posicaoComputador, int limiteLinhaChegada)
    {
        if (posicaoComputador >= limiteLinhaChegada)
        {
            Console.WriteLine($"Que pena! O computador alcançou a linha de chegada.");
            Console.WriteLine("--------------------------------------");
            Console.Write("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("--------------------------------------");
            Console.Write("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
    }

}