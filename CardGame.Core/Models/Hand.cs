
using System.Collections.Generic;

namespace CardGame.Core.Models
{
    public class Hand
    {
        public List<Card> Cards { get; } = new();
        public void Add(Card card) => Cards.Add(card);
        public void AddRange(IEnumerable<Card> cards) => Cards.AddRange(cards);
        public override string ToString() => string.Join(", ", Cards);
    }
}
