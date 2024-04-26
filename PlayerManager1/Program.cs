using System;
using System.Collections.Generic;
using System.Linq;

public class Player
{
    public string Name { get; }
    public int Score { get; }

    public Player(string name, int score)
    {
        Name = name;
        Score = score;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Player> players = new List<Player>
        {
            new Player("Player1", 100),
            new Player("Player2", 150)
        };

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Inserir jogador");
            Console.WriteLine("2. Listar todos os jogadores");
            Console.WriteLine("3. Listar jogadores com Score maior que valor indicado");
            Console.WriteLine("4. Sair");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Nome do jogador: ");
                    string name = Console.ReadLine();
                    Console.Write("Score do jogador: ");
                    int score = int.Parse(Console.ReadLine());
                    players.Add(new Player(name, score));
                    break;

                case "2":
                    ListAllPlayers(players);
                    break;

                case "3":
                    Console.Write("Introduza o valor do score mínimo: ");
                    int minScore = int.Parse(Console.ReadLine());
                    ListPlayersWithScoreGreaterThan(players, minScore);
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }

    static void ListAllPlayers(List<Player> players)
    {
        Console.WriteLine("Jogadores:");
        foreach (var player in players)
        {
            Console.WriteLine($"Nome: {player.Name}, Score: {player.Score}");
        }
    }

    static void ListPlayersWithScoreGreaterThan(List<Player> players, int minScore)
    {
        var selectedPlayers = GetPlayersWithScoreGreaterThan(players, minScore);
        Console.WriteLine($"Jogadores com Score maior que {minScore}:");
        foreach (var player in selectedPlayers)
        {
            Console.WriteLine($"Nome: {player.Name}, Score: {player.Score}");
        }
    }

    static IEnumerable<Player> GetPlayersWithScoreGreaterThan(List<Player> players, int minScore)
    {
        return players.Where(p => p.Score > minScore);
    }
}
