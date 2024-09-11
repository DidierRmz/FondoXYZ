using Microsoft.AspNetCore.Mvc;
using FondoXYZ.Repositories;
using FondoXYZ.Models;
using FondoXYZ.Interfaces;

namespace FondoXYZ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsuario(int id)
        {
            var usuario = await _usuarioRepository.GetByIdAsync(id);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }

        [HttpGet("email/{email}")]
        public async Task<IActionResult> GetUsuarioByEmail(string email)
        {
            var usuario = await _usuarioRepository.GetByEmailAsync(email);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }
    }
}