using System.ComponentModel.DataAnnotations;

namespace PeliculaCrudRazor.Models
{
    public class Peliculas
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime Realease { get; set; }
        public string Gener { get; set; }
        public decimal Price { get; set; }

    }
}
