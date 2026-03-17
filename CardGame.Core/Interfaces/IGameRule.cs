
using System.Collections.Generic;
using CardGame.Core.Models;

namespace CardGame.Core.Interfaces
{
    public interface IGameRule
    {
        void DealCards(Deck deck, IEnumerable<Player> players);
        bool CheckWinCondition(Player player);
    }
}
