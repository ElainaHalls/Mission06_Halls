using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Halls.Models
{
    public class Application 
    {
        [Key]
        [Required]
        public int ApplicationID { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [StringLength(25)]
        public string Notes { get; set; }

    }
}
