using Microsoft.EntityFrameworkCore;

namespace Server.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookCategories> BooksCategories { get; set; }
        public DbSet<Address> Addesses { get; set; }
        public DbSet<Banned> Banneds { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }
        public DbSet<Like> Likes { get; set; }
    }
}
