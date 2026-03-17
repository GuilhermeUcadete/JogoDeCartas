
using System.Collections.Generic;
using CardGame.Core.Enums;

namespace CardGame.Core.Models
{
    public class Deck
    {
        private readonly Stack<Card> _cards;

        public Deck(IEnumerable<Card> cards)
        {
            _cards = new Stack<Card>(cards);
        }

        public static Deck CreateStandard52()
        {
            var cards = new List<Card>();
            foreach (Suit s in (Suit[])System.Enum.GetValues(typeof(Suit)))
                foreach (Rank r in (Rank[])System.Enum.GetValues(typeof(Rank)))
                    cards.Add(new Card(s, r));
            return new Deck(cards);
        }

        public Card Draw() => _cards.Pop();
        public int Count => _cards.Count;
        public IEnumerable<Card> GetAllCards() => _cards.ToArray();
    }
}
