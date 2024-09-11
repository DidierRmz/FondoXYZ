using System.Data;
using FondoXYZ.Data;
using FondoXYZ.Interfaces;
using FondoXYZ.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace FondoXYZ.Services
{
    public class ReservaRepository : GenericRepository<Reserva>, IReservaRepository
    {
        public ReservaRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<Apartamento>> ConsultarDisponibilidadAsync(DateTime fechaInicio, DateTime fechaFin)
        {
            return await _context.Apartamentos
                .FromSqlRaw("EXEC sp_ConsultarDisponibilidadApartamentos @p0, @p1", fechaInicio, fechaFin)
                .ToListAsync();
        }

        public async Task CrearReservaAsync(Reserva reserva)
        {
            var totalReserva = new SqlParameter
            {
                ParameterName = "@TotalReserva",
                SqlDbType = SqlDbType.Decimal,
                Direction = ParameterDirection.Output
            };

            await _context.Database.ExecuteSqlRawAsync(
                "EXEC sp_CrearReserva @p0, @p1, @p2, @p3, @p4, @p5 OUT",
                reserva.UsuarioId, reserva.ApartamentoId, reserva.FechaInicio, reserva.FechaFin,
                reserva.NumeroPersonas, totalReserva);

            reserva.TotalReserva = (decimal)totalReserva.Value;
            await _context.Reservas.AddAsync(reserva);
            await _context.SaveChangesAsync();
        }

    }
}
