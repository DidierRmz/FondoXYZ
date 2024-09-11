using FondoXYZ.Interfaces;
using FondoXYZ.Models;
using Microsoft.AspNetCore.Mvc;

namespace FondoXYZ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SedesController : Controller
    {
        private readonly ISedeRecreativaRepository _sedeRepository;

        public SedesController(ISedeRecreativaRepository sedeRepository)
        {
            _sedeRepository = sedeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetSedes()
        {
            var sedes = await _sedeRepository.GetAllAsync();
            return Ok(sedes);
        }
    }
}
