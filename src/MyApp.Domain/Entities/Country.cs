namespace MyApp.Domain.Entities {
  public class Country {
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<Port> Ports { get; set; } = new List<Port>();
  }
}