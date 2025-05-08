namespace MyApp.Application.DTOs {
  public class ShipDto {
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public double MaxSpeed { get; set; }
  }
}