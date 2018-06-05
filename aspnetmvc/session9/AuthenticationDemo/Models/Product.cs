using System.ComponentModel.DataAnnotations;

namespace AuthenticationDemo.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20,MinimumLength =4)]
        public string  Name { get; set; }
        public int? Quantity { get; set; }
    }
}