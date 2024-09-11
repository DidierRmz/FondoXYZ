using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FondoXYZ.Models
{
    public class Habitacion
    {
        [Key]
        public int Id { get; set; }

        public string NumeroHabitacion { get; set; }
        public int NumeroCamas { get; set; }
        public int CapacidadPersonas { get; set; }
        public string TipoHabitacion { get; set; }

        [ForeignKey("Apartamento")]
        public int? ApartamentoId { get; set; }

        [JsonIgnore]
        public Apartamento Apartamento { get; set; }
    }
}