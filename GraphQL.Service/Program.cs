using GraphQL.Service.GraphQL;
using GraphQL.Service.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// add connection string to db context
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<graphQLContext>(options =>
    options.UseSqlServer(connectionString));

// add graphql
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

var app = builder.Build();

app.MapGraphQL();

app.Run();
