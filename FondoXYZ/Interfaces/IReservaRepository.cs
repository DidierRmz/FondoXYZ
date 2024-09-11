using FondoXYZ.Models;

namespace FondoXYZ.Interfaces
{
    public interface IReservaRepository : IGenericRepository<Reserva>
    {
        Task<IEnumerable<Apartamento>> ConsultarDisponibilidadAsync(DateTime fechaInicio, DateTime fechaFin);
        Task CrearReservaAsync(Reserva reserva);
    }
}