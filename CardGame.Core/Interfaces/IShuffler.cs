
using System.Collections.Generic;
using CardGame.Core.Models;

namespace CardGame.Core.Interfaces
{
    public interface IShuffler
    {
        List<Card> Shuffle(IEnumerable<Card> cards);
    }
}
