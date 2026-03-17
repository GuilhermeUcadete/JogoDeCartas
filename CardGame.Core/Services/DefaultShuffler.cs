
using System;
using System.Collections.Generic;
using System.Linq;
using CardGame.Core.Interfaces;
using CardGame.Core.Models;

namespace CardGame.Core.Services
{
    public class DefaultShuffler : IShuffler
    {
        private readonly Random _random = new();
        public List<Card> Shuffle(IEnumerable<Card> cards)
            => cards.OrderBy(c => _random.Next()).ToList();
    }
}
