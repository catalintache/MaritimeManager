using AutoMapper;
using MyApp.Application.DTOs;
using MyApp.Domain.Entities;

namespace MyApp.Infrastructure.Mapping {
  public class MappingProfile : Profile {
    public MappingProfile() {
      CreateMap<Ship, ShipDto>().ReverseMap();
      CreateMap<Voyage, VoyageDto>()
        .ForMember(d => d.ShipName, o => o.MapFrom(s => s.Ship.Name))
        .ForMember(d => d.DeparturePortName, o => o.MapFrom(s => s.DeparturePort.Name))
        .ForMember(d => d.ArrivalPortName, o => o.MapFrom(s => s.ArrivalPort.Name));
    }
  }
}