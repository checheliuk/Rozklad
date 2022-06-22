using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.Enum;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
public class HomeController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public HomeController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    [HttpGet("cites")]
    public async Task<ActionResult<IReadOnlyList<CityDto>>> GetCites()
    {
        var cites = await _unitOfWork.CityRepository.GetCitesAsync(Visible.Show);
        return Ok(_mapper.Map<IReadOnlyList<City>, IReadOnlyList<CityDto>>(cites));
    }


    [HttpGet("routes/{url}")]
    public async Task<ActionResult<IReadOnlyList<RouteDto>>> GetRoutes(string url)
    {
        var city = await _unitOfWork.CityRepository.GetCityByUrlAsync(url.ToLower(), Visible.Show);
        if (city == null) return NotFound();
        var routes = await _unitOfWork.RouteRepository.GetRoutesByCityIdAsync(city.Id);
        return Ok(_mapper.Map<IReadOnlyCollection<Core.Entities.Route>, IReadOnlyCollection<RouteDto>>(routes));
    }
}
