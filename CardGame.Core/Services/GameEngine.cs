
using System.Collections.Generic;
using CardGame.Core.Interfaces;
using CardGame.Core.Models;

namespace CardGame.Core.Services
{
    public class GameEngine
    {
        private readonly IShuffler _shuffler;
        private readonly IGameRule _rules;

        public GameEngine(IShuffler shuffler, IGameRule rules)
        {
            _shuffler = shuffler;
            _rules = rules;
        }

        public Deck PrepareDeck()
        {
            var deck = Deck.CreateStandard52();
            var shuffled = _shuffler.Shuffle(deck.GetAllCards());
            return new Deck(shuffled);
        }

        public void Deal(Deck deck, List<Player> players)
            => _rules.DealCards(deck, players);
    }
}
