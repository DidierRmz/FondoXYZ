using FondoXYZ.Data;
using FondoXYZ.Interfaces;
using FondoXYZ.Models;
using Microsoft.EntityFrameworkCore;

namespace FondoXYZ.Services
{
    public class TarifaRepository : GenericRepository<Tarifa>, ITarifaRepository
    {
        public TarifaRepository(ApplicationDbContext context) : base(context) { }
    }
}