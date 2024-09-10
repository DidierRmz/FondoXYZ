using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FondoXYZ.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

        [ForeignKey("Apartamento")]
        public int? ApartamentoId { get; set; }

        public Apartamento Apartamento { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int NumeroPersonas { get; set; }
        public decimal TotalReserva { get; set; }
    }
}