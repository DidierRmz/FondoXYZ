using Microsoft.AspNetCore.Mvc;
using FondoXYZ.Repositories;
using FondoXYZ.Models;
using FondoXYZ.Interfaces;

namespace FondoXYZ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TemporadasController : Controller
    {
        private readonly ITemporadaRepository _temporadaRepository;

        public TemporadasController(ITemporadaRepository temporadaRepository)
        {
            _temporadaRepository = temporadaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetTemporadas()
        {
            var temporadas = await _temporadaRepository.GetAllAsync();
            return Ok(temporadas);
        }
    }
}