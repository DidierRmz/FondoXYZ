using FondoXYZ.Data;
using FondoXYZ.Models;

namespace FondoXYZ.Repositories
{
    public class ApartamentoRepository : Repository<Apartamento>, IApartamentoRepository
    {
        public ApartamentoRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
