using Microsoft.EntityFrameworkCore;

namespace Book.WebApi;

public class DataBaseContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
    {}
}