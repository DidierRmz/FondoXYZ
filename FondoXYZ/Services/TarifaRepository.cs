using FondoXYZ.Data;
using FondoXYZ.Models;

namespace FondoXYZ.Repositories
{
    public class TarifaRepository : Repository<Tarifa>, ITarifaRepository
    {
        public TarifaRepository(ApplicationDbContext context) : base(context)
        {
        }

        // Métodos específicos para Tarifa, si es necesario
    }
}