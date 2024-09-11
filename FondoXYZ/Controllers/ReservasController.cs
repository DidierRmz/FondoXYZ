using FondoXYZ.Interfaces;
using FondoXYZ.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FondoXYZ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservasController : Controller
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservasController(IReservaRepository reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetReservas()
        {
            var reservas = await _reservaRepository.GetAllAsync();
            return Ok(reservas);
        }

        [HttpGet("disponibilidad")]
        public async Task<IActionResult> ConsultarDisponibilidad(DateTime fechaInicio, DateTime fechaFin)
        {
            var apartamentosDisponibles = await _reservaRepository.ConsultarDisponibilidadAsync(fechaInicio, fechaFin);
            return Ok(apartamentosDisponibles);
        }

        [HttpPost]
        public async Task<IActionResult> CrearReserva([FromBody] Reserva reserva)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await _reservaRepository.CrearReservaAsync(reserva);
                return Ok(reserva);
            }
            catch (Exception ex)
            {
                // Manejo de errores, como registrar en un log
                return StatusCode(500, $"Error al crear reserva: {ex.Message}");
            }
        }
    }
}
