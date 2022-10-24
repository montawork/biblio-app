using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class Like
    {
        [Key]
        public int LikeID { get; set; }
        [DefaultValue(0)]
        public int Value { get; set; }

        public int UserID { get; set; }
        public User? User { get; set; }

        public int UserBookID { get; set; }
        public UserBook? UserBook { get; set; }
    }
}
