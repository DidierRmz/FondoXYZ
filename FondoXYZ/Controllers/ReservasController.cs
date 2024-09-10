using Microsoft.AspNetCore.Mvc;
using FondoXYZ.Repositories;
using FondoXYZ.Models;

public class ReservasController : Controller
{
    private readonly IReservaRepository _reservaRepository;

    public ReservasController(IReservaRepository reservaRepository)
    {
        _reservaRepository = reservaRepository;
    }

    public async Task<IActionResult> Index()
    {
        var reservas = await _reservaRepository.GetAllAsync();
        return View(reservas);
    }
}
