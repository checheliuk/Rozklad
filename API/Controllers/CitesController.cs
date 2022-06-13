using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
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
    }
}