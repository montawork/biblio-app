using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Server.Models
{
    public class BookCategories
    {
        [Key]
        public int BookCategoriesID { get; set; }
        [Required]
        public int BookID { get; set; }
        public Book? Book { get; set; }
        [Required]
        public int CategoryID { get; set; }
        public Category? Category { get; set; }

    }
}
