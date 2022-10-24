using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Server.Models
{
    public class UserBook
    {
        [Key]
        public int UserBookID { get; set; }
        [Required(ErrorMessage = "Serial Number is Required")]
        public int SerialNumber { get; set; }
        [Required(ErrorMessage = "Status is Required")]
        public string Status { get; set; }
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Picture is Required")]
        public string Picture { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserID { get; set; }
        public User? User { get; set; }
        public int BookID { get; set; }
        public Book? Book { get; set; }


        public List<Like> Likes { get; set; } = new List<Like>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public List<Collection> Collections { get; set; } = new List<Collection>();
        public List<Borrow> Borrows { get; set; } = new List<Borrow>();
        public List<Exchange> Exchanges { get; set; } = new List<Exchange>();
    }
}
