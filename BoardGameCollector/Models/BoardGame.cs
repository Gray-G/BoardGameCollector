using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoardGameCollector.Models
{
    public class BoardGameManager
    {
        public static List<BoardGame> GetBoardGames()
        {
            return new List<BoardGame> {
                new BoardGame { GameId = 1, Title = "Settlers of Catan",
                NumberOfPlayers = new List<int> { 4, 5 }, MinGameLength = 60, MaxGameLength = 240,
                Difficulty = Enums.Difficulty.Medium,
                Description = "Players assume the roles of settlers, each attempting to build " +
                "and develop holdings while trading and acquiring resources. Players are awarded points " +
                "as their settlements grow; the first to reach a set number of points, typically 10, is the winner."
                },
                new BoardGame { GameId = 2, Title = "Carcassone",
                NumberOfPlayers = new List<int> { 2, 3, 4, 5 }, MinGameLength = 30, MaxGameLength = 90,
                Difficulty = Enums.Difficulty.Easy,
                Description = "The game board is a medieval landscape built by the players as the game " +
                "progresses. The game starts with a single terrain tile face up and 71 others shuffled face " +
                "down for the players to draw from. On each turn a player draws a new terrain tile and places " +
                "it adjacent to tiles that are already face up, with the goal of completeing features for points. " +
                "The game ends when there are no more tiles to draw."
                }
            };
        }
    }

    public class BoardGame
    {
        public int GameId { get; set; }
        public string Title { get; set; }
        public int MinGameLength { get; set; }
        public int MaxGameLength { get; set; }
        public List<int> NumberOfPlayers { get; set; }
        public BoardGameCollector.Enums.Difficulty Difficulty { get; set; }
        public string Description { get; set; }
    }

}