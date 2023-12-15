using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AtPetShop.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "max length is 100")]
        public string ShortDescription { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public string Category { get; set; }

        public string ImageFile { get; set; }

        //public string ImageFileName { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }

        public int ShelfLocationId { get; set; }
        public ShelfLocation? ShelfLocation { get; set; }
    }

}
