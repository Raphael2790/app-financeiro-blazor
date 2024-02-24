namespace AgioBank.Contexts.SharedContext.Entities
{
    public class Entidade : IEquatable<string>
    {
        public string Id { get; set; } = string.Empty;
        public bool Equals(string? id) => Id == id;
    }
}
