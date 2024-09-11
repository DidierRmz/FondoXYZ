using Microsoft.AspNetCore.Mvc;
using FondoXYZ.Repositories;
using FondoXYZ.Models;
using FondoXYZ.Interfaces;

namespace FondoXYZ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarifasController : Controller
    {
        private readonly ITarifaRepository _tarifaRepository;

        public TarifasController(ITarifaRepository tarifaRepository)
        {
            _tarifaRepository = tarifaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetTarifas()
        {
            var tarifas = await _tarifaRepository.GetAllAsync();
            return Ok(tarifas);
        }
    }
}