using FondoXYZ.Models;

namespace FondoXYZ.Interfaces
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        Task<Usuario> GetByEmailAsync(string email);
    }
}