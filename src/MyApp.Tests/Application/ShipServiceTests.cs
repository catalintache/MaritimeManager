using Moq;
using Xunit;
using AutoMapper;
using MyApp.Application.Interfaces;
using MyApp.Infrastructure.Repositories;
using MyApp.Infrastructure.Services;
using MyApp.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ShipServiceTests {
  private readonly Mock<IRepository<Ship>> _repo = new();
  private readonly IMapper _mapper;

  public ShipServiceTests() {
    var cfg = new MapperConfiguration(c => c.AddProfile(new MappingProfile()));
    _mapper = cfg.CreateMapper();
  }

  [Fact]
  public async Task GetAllAsync_ReturnsAllShips() {
    _repo.Setup(r => r.GetAllAsync()).ReturnsAsync(new List<Ship> {
      new() { Id = 1, Name = "A", MaxSpeed=10 }
    });
    var svc = new ShipService(_repo.Object, _mapper);
    var result = await svc.GetAllAsync();
    Assert.Single(result);
  }
}