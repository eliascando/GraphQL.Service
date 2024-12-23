using GraphQL.Service.Models;
using GraphQL.Service.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Service.GraphQL
{
    public class Query
    {
        public async Task<Book> GetBookById(int id, [Service] graphQLContext context)
        {
            return await context.Books.FindAsync(id) ?? throw new Exception($"Id: {id} no tiene un libro asociado!");
        }

        public async Task<List<Book>> GetBooks([Service] graphQLContext context)
        {
            return await context.Books.ToListAsync();
        }
    }
}
