using System.ComponentModel.DataAnnotations;

namespace FondoXYZ.Models
{
    public class Temporada
    {
        [Key]
        public int Id { get; set; }

        public string NombreTemporada { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}