using MongodbGraphqlDemo.Models.repository;
using MongodbGraphqlDemo.Schema;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<MongoDbContext>();
builder.Services.AddGraphQLServer();
builder.Services.AddGraphQL()
    .AddQueryType<Query>()
    .AddType<ProductType>()
    .AddMutationType<Mutation>()
    // Add other types and resolvers as needed
    .AddMongoDbProjections()
    .AddMongoDbFiltering()
    .AddMongoDbSorting();
var app = builder.Build();

app.MapGraphQL("/graphql");
app.Run();
