using Microsoft.AspNetCore.Mvc;
using MyApp.Application.DTOs;
using MyApp.Application.Interfaces;

namespace MyApp.WebAPI.Controllers {
  [ApiController]
  [Route("api/[controller]")]
  public class ShipsController : ControllerBase {
    private readonly IShipService _svc;
    public ShipsController(IShipService svc) => _svc = svc;

    [HttpGet]
    public async Task<IActionResult> GetAll() =>
      Ok(await _svc.GetAllAsync());

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id) {
      var ship = await _svc.GetByIdAsync(id);
      return ship is null ? NotFound() : Ok(ship);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ShipDto dto) {
      var created = await _svc.CreateAsync(dto);
      return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] ShipDto dto) {
      await _svc.UpdateAsync(id, dto);
      return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id) {
      await _svc.DeleteAsync(id);
      return NoContent();
    }
  }
}