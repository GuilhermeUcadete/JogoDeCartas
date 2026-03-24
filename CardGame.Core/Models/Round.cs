using System;
using System.Collections.Generic;

namespace JogoDeCartas.Models
{
    public class Round
    {
        public int RoundNumber { get; set; }
        // Guarda o ID do jogador e a carta que ele jogou
        public Dictionary<Guid, Card> PlayedCards { get; set; } = new Dictionary<Guid, Card>();
        public Guid? WinnerId { get; set; }

        public Round(int number)
        {
            RoundNumber = number;
        }
    }
}