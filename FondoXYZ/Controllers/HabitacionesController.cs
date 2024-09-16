using Microsoft.AspNetCore.Mvc;
using FondoXYZ.Repositories;
using FondoXYZ.Models;
using FondoXYZ.Interfaces;

namespace FondoXYZ.Controllers
{

    public class HabitacionesController : Controller
    {
        private readonly IHabitacionRepository _habitacionRepository;

        public HabitacionesController(IHabitacionRepository habitacionRepository)
        {
            _habitacionRepository = habitacionRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetHabitaciones()
        {
            var habitaciones = await _habitacionRepository.GetAllAsync();
            return Ok(habitaciones);
        }
    }
}