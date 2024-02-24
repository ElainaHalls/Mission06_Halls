using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Halls.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        
        public string? CategoryName { get; set; }
    }
}
