using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Week5.Models
{
    public class Restaurant
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string restaurantName { get; set; }
        public string foodName { get; set; }
        [Required] 
        public float foodPrice { get; set; }
        [Required]
        public int foodQuantity { get; set; }
        [ForeignKey("Province")]
        public int? ProvinceId { get; set; }
        public Province? province { get; set; }
    }
}
