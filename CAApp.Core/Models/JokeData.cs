namespace CAApp.Core.Models
{
    public class JokeData
    {
        public int Id { get; set; }
        public required string Type { get; set; }
        public required string Setup { get; set; }
        public required string Punchline { get; set;
        }
    }
}
