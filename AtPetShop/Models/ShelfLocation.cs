using System.ComponentModel.DataAnnotations;

namespace AtPetShop.Models
{
    public class ShelfLocation
    {
        public int Id { get; set; }
        [Required]
        public int Row { get; set; }
        [Required]
        public int Column { get; set; }
        [Required]
        public int Aisle { get; set; }
        [Required]
        public DateTime Created { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
