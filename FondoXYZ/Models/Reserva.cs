using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FondoXYZ.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Usuario")]
        [Required]
        public int UsuarioId { get; set; }

        [JsonIgnore]
        public Usuario Usuario { get; set; }

        [ForeignKey("Apartamento")]
        public int? ApartamentoId { get; set; }

        [JsonIgnore]
        public Apartamento Apartamento { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        [Required]
        public DateTime FechaFin { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Número de personas debe ser mayor que 0.")]
        public int NumeroPersonas { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Total reserva debe ser mayor o igual a 0.")]
        public decimal TotalReserva { get; set; }
    }


}
