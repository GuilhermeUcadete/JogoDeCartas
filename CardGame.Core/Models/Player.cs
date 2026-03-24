namespace JogoDeCartas.Models
{
    public class Player
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // ID único para o histórico
        public string Name { get; set; }
        public int Wins { get; set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}