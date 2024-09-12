using Microsoft.AspNetCore.Mvc;
using FondoXYZ.Repositories;
using FondoXYZ.Models;
using FondoXYZ.Interfaces;
using Microsoft.EntityFrameworkCore;
using FondoXYZ.Data;
using Microsoft.AspNetCore.Authorization;

namespace FondoXYZ.Controllers
{
    public class ApartamentosController : Controller
    {
        private readonly IApartamentoRepository _apartamentoRepository;

        public ApartamentosController(IApartamentoRepository apartamentoRepository)
        {
            _apartamentoRepository = apartamentoRepository;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            //var apartamentos = await _apartamentoRepository.GetAllApartamentosAsync();
            return View();
        }
    }
}