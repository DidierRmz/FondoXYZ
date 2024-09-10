using FondoXYZ.Data;
using FondoXYZ.Models;

namespace FondoXYZ.Repositories
{
    public class SedeRecreativaRepository : Repository<SedeRecreativa>, ISedeRecreativaRepository
    {
        public SedeRecreativaRepository(ApplicationDbContext context) : base(context)
        {
        }

        // Métodos específicos para SedeRecreativa, si es necesario
    }
}