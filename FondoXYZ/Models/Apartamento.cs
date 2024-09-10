using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FondoXYZ.Models
{
    public class Apartamento
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }
        public int CapacidadMaxima { get; set; }

        [ForeignKey("SedeRecreativa")]
        public int SedeId { get; set; }

        public SedeRecreativa SedeRecreativa { get; set; }

        public ICollection<Habitacion> Habitaciones { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
    }
}