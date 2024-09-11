using FondoXYZ.Data;
using FondoXYZ.Interfaces;
using FondoXYZ.Models;
using Microsoft.EntityFrameworkCore;

namespace FondoXYZ.Services
{
    public class TemporadaRepository : GenericRepository<Temporada>, ITemporadaRepository
    {
        public TemporadaRepository(ApplicationDbContext context) : base(context) { }
    }
}