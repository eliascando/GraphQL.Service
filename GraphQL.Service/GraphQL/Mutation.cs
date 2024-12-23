using GraphQL.Service.Models;
using GraphQL.Service.Persistence;

namespace GraphQL.Service.GraphQL
{
    public class Mutation
    {
        public async Task<bool> DeleteBook(int id, [Service] graphQLContext context)
        {
            var book = await context.Books.FindAsync(id);
            if (book == null)
            {
                return false;
            }

            context.Books.Remove(book);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<Book> AddBook(string title, string author, [Service] graphQLContext context)
        {
            var book = new Book { Title = title, Author = author };
            context.Books.Add(book);
            await context.SaveChangesAsync();
            return book;
        }
    }
}
