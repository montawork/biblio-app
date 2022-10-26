using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Server.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required(ErrorMessage = "Picture is Required")]
        public string Picture { get; set; }
        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Pages Number is Required")]
        public int Pages { get; set; }
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Creation Date is Required")]
        public DateTime CreationDate { get; set; }
        [Required(ErrorMessage = "Author is Required")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Language is Required")]
        public string Language { get; set; }
        [Required(ErrorMessage = "Category is Required")]
        public int IsAccepted { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<BookCategories> BookCategories { get; set; } = new List<BookCategories>();
    }
}
