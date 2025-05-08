namespace MyApp.Domain.Entities {
  public class Voyage {
    public int Id { get; set; }
    public int ShipId { get; set; }
    public Ship Ship { get; set; } = null!;
    public int DeparturePortId { get; set; }
    public Port DeparturePort { get; set; } = null!;
    public int ArrivalPortId { get; set; }
    public Port ArrivalPort { get; set; } = null!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
  }
}