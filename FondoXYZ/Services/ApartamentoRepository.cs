using FondoXYZ.Data;
using FondoXYZ.Interfaces;
using FondoXYZ.Models;
using FondoXYZ.Services;
using Microsoft.EntityFrameworkCore;

namespace FondoXYZ.Repositories
{
    public class ApartamentoRepository : IApartamentoRepository
    {
        private readonly ApplicationDbContext _context;

        public ApartamentoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Apartamento>> GetAllApartamentosAsync()
        {
            return await _context.Apartamentos
                .Include(a => a.SedeRecreativa)
                .ToListAsync();
        }
    }

}
