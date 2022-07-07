using API.Dtos;
using AutoMapper;
using Core.Entities;
using Route = Core.Entities.Route;

namespace API.Helpers;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<City, CityDto>();
        CreateMap<Route, RouteDto>();
        CreateMap<Description, DescriptionDto>();
        CreateMap<Station, StationDto>();
    }
}