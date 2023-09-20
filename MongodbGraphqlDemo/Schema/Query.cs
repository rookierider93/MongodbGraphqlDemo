using MongodbGraphqlDemo.Models.repository;
using MongodbGraphqlDemo.Models;
using MongoDB.Driver;

namespace MongodbGraphqlDemo.Schema
{
    public class Query
    {
        public IQueryable<Product> GetProducts([Service] MongoDbContext dbContext)
        {
            // Convert IMongoCollection<Product> to IQueryable<Product>
            return dbContext.Products.AsQueryable();
        }
    }
}
