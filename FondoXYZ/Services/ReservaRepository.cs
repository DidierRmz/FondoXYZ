using FondoXYZ.Data;
using FondoXYZ.Models;

namespace FondoXYZ.Repositories
{
    public class ReservaRepository : Repository<Reserva>, IReservaRepository
    {
        public ReservaRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
