using Microsoft.AspNetCore.Mvc;
using FondoXYZ.Repositories;
using FondoXYZ.Models;
using FondoXYZ.Interfaces;
using Microsoft.EntityFrameworkCore;
using FondoXYZ.Data;

namespace FondoXYZ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApartamentosController : Controller
    {
        private readonly IApartamentoRepository _apartamentoRepository;

        public ApartamentosController(IApartamentoRepository apartamentoRepository)
        {
            _apartamentoRepository = apartamentoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var apartamentos = await _apartamentoRepository.GetAllApartamentosAsync();
            return View(apartamentos);
        }
    }
}