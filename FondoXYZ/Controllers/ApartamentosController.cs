using Microsoft.AspNetCore.Mvc;
using FondoXYZ.Repositories;
using FondoXYZ.Models;
using FondoXYZ.Interfaces;
using Microsoft.EntityFrameworkCore;
using FondoXYZ.Data;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Authorization;

namespace FondoXYZ.Controllers
{
    [Authorize]
    public class ApartamentosController : Controller
    {
        private readonly IApartamentoRepository _apartamentoRepository;
        private readonly ApplicationDbContext _context;

        public ApartamentosController(IApartamentoRepository apartamentoRepository, ApplicationDbContext context)
        {
            _apartamentoRepository = apartamentoRepository;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var apartamentos = await _apartamentoRepository.GetAllApartamentosAsync();
            return View(apartamentos);
        }

        // Método para consultar disponibilidad
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConsultarDisponibilidad([FromBody] ConsultaDisponibilidadRequest request)
        {
            try
            {
                var reservas = 0;
                var connection = _context.Database.GetDbConnection();
                await connection.OpenAsync();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "ConsultarDisponibilidad";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@p_ApartamentoId", request.ApartamentoId));
                    command.Parameters.Add(new SqlParameter("@p_FechaInicio", request.FechaInicio));
                    command.Parameters.Add(new SqlParameter("@p_FechaFin", request.FechaFin));

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            reservas = reader.GetInt32(0);
                        }
                    }
                }

                return Json(new { reservas });
            }
            catch (Exception ex)
            {
                // Log the error
                // _logger.LogError(ex, "Error al consultar disponibilidad.");
                return StatusCode(500, new { error = "Error interno del servidor." });
            }
        }

        // Método para calcular la tarifa
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CalcularTarifa([FromBody] CalcularTarifaRequest request)
        {
            try
            {
                var tarifaTotal = 0m;
                var connection = _context.Database.GetDbConnection();
                await connection.OpenAsync();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "CalcularTarifa";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@p_ApartamentoId", request.ApartamentoId));
                    command.Parameters.Add(new SqlParameter("@p_Temporada", request.Temporada));
                    command.Parameters.Add(new SqlParameter("@p_NumeroPersonas", request.NumeroPersonas));
                    var tarifaTotalParam = new SqlParameter("@p_TarifaTotal", System.Data.SqlDbType.Decimal)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    command.Parameters.Add(tarifaTotalParam);

                    await command.ExecuteNonQueryAsync();
                    tarifaTotal = (decimal)tarifaTotalParam.Value;
                }

                return Json(new { tarifaTotal });
            }
            catch (Exception ex)
            {
                // Log the error
                // _logger.LogError(ex, "Error al calcular la tarifa.");
                return StatusCode(500, new { error = "Error interno del servidor." });
            }
        }
    }

    public class ConsultaDisponibilidadRequest
    {
        public int ApartamentoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }

    public class CalcularTarifaRequest
    {
        public int ApartamentoId { get; set; }
        public string Temporada { get; set; }
        public int NumeroPersonas { get; set; }
    }
}
