using FondoXYZ.Data;
using FondoXYZ.Models;

namespace FondoXYZ.Repositories
{
    public class TemporadaRepository : Repository<Temporada>, ITemporadaRepository
    {
        public TemporadaRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}