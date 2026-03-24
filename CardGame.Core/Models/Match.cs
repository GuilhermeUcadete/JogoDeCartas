using System;
using System.Collections.Generic;

namespace JogoDeCartas.Models
{
    public class Match
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Date { get; set; } = DateTime.Now;
        public List<Player> Players { get; set; } = new List<Player>();
        public List<Round> Rounds { get; set; } = new List<Round>();
        public string WinnerName { get; set; }

        public Match() { } 
    }
}