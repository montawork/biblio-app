using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Server.Models
{
    public class Borrow
    {
        [Key]
        public int BorrowID { get; set; }

        [Required(ErrorMessage = "Start Date is Required")]

        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date is Required")]

        public DateTime EndDate { get; set; }

        public int UserID { get; set; }
        public User? User { get; set; }

        public int UserBookID { get; set; }
        public UserBook? UserBook { get; set; }
    }
}
