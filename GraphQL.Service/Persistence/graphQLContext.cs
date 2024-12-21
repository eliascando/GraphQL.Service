using GraphQL.Service.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Service.Persistence
{
    public class graphQLContext : DbContext
    {
        public graphQLContext(DbContextOptions<graphQLContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
