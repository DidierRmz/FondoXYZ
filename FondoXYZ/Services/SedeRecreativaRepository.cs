using FondoXYZ.Models;
using FondoXYZ.Data;
using FondoXYZ.Interfaces;
using Microsoft.EntityFrameworkCore;
using FondoXYZ.Services;

namespace FondoXYZ.Repositories
{
    public class SedeRecreativaRepository : GenericRepository<SedeRecreativa>, ISedeRecreativaRepository
    {
        public SedeRecreativaRepository(ApplicationDbContext context) : base(context) { }
    }
}