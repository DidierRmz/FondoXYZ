using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FondoXYZ.Models
{
    public class Apartamento
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }
        public int CapacidadMaxima { get; set; }

        [ForeignKey("SedesRecreativas")]
        public int SedeId { get; set; }

        [JsonIgnore]
        public SedeRecreativa SedeRecreativa { get; set; }

        public ICollection<Habitacion> Habitaciones { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
    }
}