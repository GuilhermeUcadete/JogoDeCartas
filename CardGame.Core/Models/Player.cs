
namespace CardGame.Core.Models
{
    public class Player
    {
        public string Name { get; }
        public Hand Hand { get; } = new();
        public Player(string name) { Name = name; }
        public override string ToString() => Name;
    }
}
