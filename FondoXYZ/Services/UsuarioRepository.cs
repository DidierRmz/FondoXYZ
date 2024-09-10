using FondoXYZ.Models;
using FondoXYZ.Data;

namespace FondoXYZ.Repositories
{
    public class UsuarioRepository : Repository<Usuario>
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context)
        {
        }
        
    }
}
