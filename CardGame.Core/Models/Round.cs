
using System.Collections.Generic;

namespace CardGame.Core.Models
{
    public class Round
    {
        public int Number { get; }
        public List<Player> Players { get; }
        public Round(int number, List<Player> players)
        {
            Number = number;
            Players = players;
        }
    }
}
