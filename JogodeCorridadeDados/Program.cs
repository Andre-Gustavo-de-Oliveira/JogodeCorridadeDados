// See https://aka.ms/new-console-template for more information
int posicaoJogador = 0, posicaoComputador = 0, rodada = 1;
string jogador;
Random random = new Random();

Console.WriteLine("Bem Vindo a corrida de dados!");
Console.WriteLine("Nessa corrida você vai disputar contra a máquina! Em uma corrida de sorte!");
Console.WriteLine("Será disputado quem chegará ou passará do número 30 primeiro!");

Console.WriteLine("Por favor insira seu Nome: ");
string nomeCompleto = Console.ReadLine();

Console.WriteLine("O seu nome é:" + nomeCompleto);

jogador = nomeCompleto;

Console.WriteLine("A corrida vai começar! ");

Console.WriteLine("Pressione ENTER para rolar o dado");
Console.ReadLine();

while (posicaoJogador < 30 && posicaoComputador < 30)

{
    Console.WriteLine($"Rodada N° {rodada}");
    Console.WriteLine($"{jogador}, pressione ENTER para rolar o dado!");
    Console.ReadLine();

    int dadoJogador = random.Next(1, 7);
    posicaoJogador += dadoJogador;
    Console.WriteLine($"{jogador} tirou {dadoJogador} e está na posição {posicaoJogador}");

    if (posicaoJogador == 05 || posicaoJogador == 10 || posicaoJogador == 15 || posicaoJogador == 25)
    {
        Console.WriteLine($"Se deu bem {jogador} ! Você avança 3 casas!");
        posicaoJogador += 3;
        Console.WriteLine($"Nova posição: {posicaoJogador}");
    }
    else if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20)
    {
        Console.WriteLine($"Deu Ruim! {jogador} ! Você volta 2 casas!");
        posicaoJogador -= 2;
        Console.WriteLine($"Nova posição: {posicaoJogador}");
    }

    if (dadoJogador == 6)
    {
        Console.WriteLine($"{jogador} tirou 6 e ganha uma jogada extra!");
        Thread.Sleep(1000);
        int dadoExtra = random.Next(1, 7);
        posicaoJogador += dadoExtra;
        Console.WriteLine($"{jogador} tirou {dadoExtra} na jogada extra e agora está na posição {posicaoJogador}");

        if (posicaoJogador == 05 || posicaoJogador == 10 || posicaoJogador == 15 || posicaoJogador == 25)
        {
            Console.WriteLine($"Se deu bem {jogador}! Você avança 3 casas!");
            posicaoJogador += 3;
        }
        else if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20)
        {
            Console.WriteLine($"Deu ruim! {jogador}! Você volta 2 casas!");
            posicaoJogador -= 2;
            if (posicaoJogador < 0)
                posicaoJogador = 0;
        }
        Console.WriteLine($"Nova posição final do jogador: {posicaoJogador}");
    }


    Thread.Sleep(1000);
    int dadoComputador = random.Next(1, 7);
    posicaoComputador += dadoComputador;
    Console.WriteLine($"Computador tirou {dadoComputador} e está na posição {posicaoComputador}");

    if (posicaoComputador == 05 || posicaoComputador == 10 || posicaoComputador == 15 || posicaoComputador == 25)
    {
        Console.WriteLine("CPU se deu Bem! avança 3 casas!");
        posicaoComputador += 3;
        Console.WriteLine($"Nova posição: {posicaoComputador}");
    }
    else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
    {
        Console.WriteLine("CPU se deu mal! volta 2 casas!");
        posicaoComputador -= 2;

        Console.WriteLine($"Nova posição: {posicaoComputador}");
    }

    if (dadoComputador == 6)
    {
        Console.WriteLine("CPU tirou 6 e ganha uma jogada extra!");
        Thread.Sleep(1000);
        int dadoExtraCPU = random.Next(1, 7);
        posicaoComputador += dadoExtraCPU;
        Console.WriteLine($"CPU tirou {dadoExtraCPU} na jogada extra e agora está na posição {posicaoComputador}");

        if (posicaoComputador == 05 || posicaoComputador == 10 || posicaoComputador == 15 || posicaoComputador == 25)
        {
            Console.WriteLine("CPU se deu bem! Avança 2 casas!");
            posicaoComputador += 2;
        }
        else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
        {
            Console.WriteLine("CPU se deu mal! Volta 2 casas!");
            posicaoComputador -= 2;
            if (posicaoComputador < 0)
                posicaoComputador = 0;
        }
        Console.WriteLine($"Nova posição final do computador: {posicaoComputador}");
    }

    rodada++;
}

if (posicaoJogador >= 30 && posicaoComputador >= 30)

    Console.WriteLine("Empate!!");

else if (posicaoJogador >= 30)

    Console.WriteLine(jogador + " Ganhou!!");

else
    Console.WriteLine("Computador ganhou!!");
