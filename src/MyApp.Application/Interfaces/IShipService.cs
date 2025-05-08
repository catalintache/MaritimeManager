namespace MyApp.Application.Interfaces {
  public interface IShipService {
    Task<IEnumerable<ShipDto>> GetAllAsync();
    Task<ShipDto?> GetByIdAsync(int id);
    Task<ShipDto> CreateAsync(ShipDto dto);
    Task UpdateAsync(int id, ShipDto dto);
    Task DeleteAsync(int id);
  }
}