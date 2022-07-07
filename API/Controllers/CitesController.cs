using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Route = Core.Entities.Route;

namespace API.Controllers;
public class CitesController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CitesController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<CityDto>>> GetCites()
    {
        var cites = await _unitOfWork.CityRepository.GetCitesAsync();
        return Ok(_mapper.Map<IReadOnlyList<City>, IReadOnlyList<CityDto>>(cites));
    }

    [HttpGet("{cityId}")]
    public async Task<ActionResult<CityDto>> GetCity(int cityId) 
    {
        var city = await _unitOfWork.CityRepository.GetCityByIdAsync(cityId);
        if (city == null) return NotFound();
        else return Ok(_mapper.Map<City, CityDto>(city));
    }

    [HttpGet("{cityId}/descriptions")]
    public async Task<ActionResult<IReadOnlyList<DescriptionDto>>> GetDescriptions(int cityId)
    {
        var description = await _unitOfWork.DescriptionRepository.GetDescriptionsByCityIdAsync(cityId);
        return Ok(_mapper.Map<IReadOnlyList<Description>, IReadOnlyList<DescriptionDto>>(description));
    }

    [HttpGet("{cityId}/routes")]
    public async Task<ActionResult<IReadOnlyList<RouteDto>>> GetRoutes(int cityId)
    {
        var routes = await _unitOfWork.RouteRepository.GetRoutesByCityIdAsync(cityId);
        return Ok(_mapper.Map<IReadOnlyList<Route>, IReadOnlyList<RouteDto>>(routes));
    }

    [HttpGet("{cityId}/stations")]
    public async Task<ActionResult<IReadOnlyList<StationDto>>> GetStations(int cityId)
    {
        var stations = await _unitOfWork.StationRepository.GetStationsByCityIdAsync(cityId);
        return Ok(_mapper.Map<IReadOnlyList<Station>, IReadOnlyList<StationDto>>(stations));
    }
}