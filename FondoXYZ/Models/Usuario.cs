using System.ComponentModel.DataAnnotations;

namespace FondoXYZ.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        public string NombreUsuario { get; set; }
        public string CorreoElectronico { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }


        public ICollection<Reserva> Reservas { get; set; }
    }
}