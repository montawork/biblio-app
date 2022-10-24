using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Server.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        [Required(ErrorMessage = "Content is Required")]
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserID { get; set; }
        public User? User { get; set; }
        public int UserBookID { get; set; }
        public UserBook? UserBook { get; set; }
    }
}
