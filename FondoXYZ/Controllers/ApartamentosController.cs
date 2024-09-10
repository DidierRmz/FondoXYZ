using Microsoft.AspNetCore.Mvc;
using FondoXYZ.Repositories;
using FondoXYZ.Models;

public class ApartamentosController : Controller
{
    private readonly IApartamentoRepository _apartamentoRepository;

    public ApartamentosController(IApartamentoRepository apartamentoRepository)
    {
        _apartamentoRepository = apartamentoRepository;
    }

    public async Task<IActionResult> Index()
    {
        var apartamentos = await _apartamentoRepository.GetAllAsync();
        return View(apartamentos);
    }
}