using FondoXYZ.Data;
using FondoXYZ.Interfaces;
using FondoXYZ.Models;
using FondoXYZ.Services;
using Microsoft.EntityFrameworkCore;

namespace FondoXYZ.Services
{
public class HabitacionRepository : GenericRepository<Habitacion>, IHabitacionRepository
{
    public HabitacionRepository(ApplicationDbContext context) : base(context) { }
}
}