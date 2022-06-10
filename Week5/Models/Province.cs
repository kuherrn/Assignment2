using System.ComponentModel.DataAnnotations;

namespace Week5.Models {
    public class Province {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }    
        public int operatingYears { get; set; }
        public ICollection<Restaurant>? franchiseLocation { get; set; }
    }
}
