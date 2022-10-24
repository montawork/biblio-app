using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Server.Models
{
    public class Collection
    {
        [Key]
        public int CollectionID { get; set; }
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserID { get; set; }
        public User? User { get; set; }
        public int UserBookID { get; set; }
        public UserBook? UserBook { get; set; }
    }
}
