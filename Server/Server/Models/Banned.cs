using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Server.Models
{
    public class Banned
    {
        [Key]
        public int BannedID { get; set; }
        [Required(ErrorMessage = "Status is Required")]
        public int Status { get; set; }
        [Required(ErrorMessage = "Start date is Required")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "End date is Required")]
        public DateTime EndDate { get; set; }

        public int UserID { get; set; }
        public User? User { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
