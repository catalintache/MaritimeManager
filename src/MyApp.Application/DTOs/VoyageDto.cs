namespace MyApp.Application.DTOs {
  public class VoyageDto {
    public int Id { get; set; }
    public int ShipId { get; set; }
    public string ShipName { get; set; } = null!;
    public int DeparturePortId { get; set; }
    public string DeparturePortName { get; set; } = null!;
    public int ArrivalPortId { get; set; }
    public string ArrivalPortName { get; set; } = null!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
  }
}