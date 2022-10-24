using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Server.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public List<BookCategories> CategoryBooks { get; set; } = new List<BookCategories>();

    }
}
