namespace MyApp.Domain.Entities {
  public class Ship {
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public double MaxSpeed { get; set; }
  }
}