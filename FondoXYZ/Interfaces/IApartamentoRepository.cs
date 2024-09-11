using System.Collections.Generic;
using System.Threading.Tasks;
using FondoXYZ.Models;

namespace FondoXYZ.Interfaces
{
    public interface IApartamentoRepository
    {
        Task<IEnumerable<Apartamento>> GetAllApartamentosAsync();
    }

}
