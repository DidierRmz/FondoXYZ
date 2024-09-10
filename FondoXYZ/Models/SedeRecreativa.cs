using System.ComponentModel.DataAnnotations;

namespace FondoXYZ.Models
{
    public class SedeRecreativa
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }
        public int CapacidadTotal { get; set; }


        public ICollection<Apartamento> Apartamentos { get; set; }
    }
}