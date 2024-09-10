using System.ComponentModel.DataAnnotations;

namespace FondoXYZ.Models
{
    public class Tarifa
    {
        [Key]
        public int Id { get; set; }

        public string Temporada { get; set; }
        public string TipoAlojamiento { get; set; }
        public decimal TarifaPorNoche { get; set; }
        public int CapacidadMaxima { get; set; }
    }
}