using System;

namespace Jokenpo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 Pedra
            // 2 Papel
            // 3 Tesoura
            int playerOne = 0;
            int playerTwo = 0;
            var array = new bool?[3, 3];

            array[0, 1] = false;
            array[0, 2] = true;

            array[1, 0] = true;
            array[1, 2] = false;

            array[2, 0] = false;
            array[2, 1] = true;

            do
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Bem vindo ao jogo de Jokenpo!");
                    Console.WriteLine("Escolha seu objeto:");
                    Console.WriteLine("1 => Pedra");
                    Console.WriteLine("2 => Papel");
                    Console.WriteLine("3 = Tesouro");

                    Console.WriteLine("Jogador 1 digite o número do objeto que deseja utilizar: ");
                    playerOne = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Jogador 2 digite o número do objeto que deseja utilizar: ");
                    playerTwo = Int32.Parse(Console.ReadLine());

                    Console.WriteLine();
                    switch (array[playerOne - 1, playerTwo - 1])
                    {
                        case true:
                            Console.WriteLine("Parabéns Jogador 1 você é o vencedor!");
                            break;
                        case false:
                            Console.WriteLine("Parabéns Jogador 2 você é o vencedor!");
                            break;
                        default:
                            Console.WriteLine("Tivemos um empate, sem vencedor.");
                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Deseja jogar uma nova partida:");
                    Console.WriteLine("1 => Sim");
                    Console.WriteLine("2 => Não");
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Algo aconteceu de errado!");
                    Console.WriteLine("Deseja jogar uma nova partida:");
                    Console.WriteLine("1 => Sim");
                    Console.WriteLine("2 => Não");
                }

            } while (Console.ReadLine() == "1");

        }
    }
}
