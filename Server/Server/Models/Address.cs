using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Server.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        [Required(ErrorMessage = "City is Required")]
        public string City { get; set; }
        [Required(ErrorMessage = "ZipCode is Required")]
        public int ZipCode { get; set; }
        [Required(ErrorMessage = "Street is Required")]
        public string Street { get; set; }

        // USERS ADDRESS
        public List<User> UsersAddress { get; set; } = new List<User>();
    }
}
