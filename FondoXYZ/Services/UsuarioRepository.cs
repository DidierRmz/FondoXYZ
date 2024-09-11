using FondoXYZ.Data;
using FondoXYZ.Interfaces;
using FondoXYZ.Models;
using Microsoft.EntityFrameworkCore;

namespace FondoXYZ.Services
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context) { }

        public async Task<Usuario> GetByEmailAsync(string email)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(u => u.CorreoElectronico == email);
        }
    }
}
