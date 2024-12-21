using GraphQL.Service.Models;
using GraphQL.Service.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Service.GraphQL
{
    public class Query
    {
        public async Task<List<Book>> GetBooks([Service] graphQLContext context)
        {
            return await context.Books.ToListAsync();
        }
    }
}
