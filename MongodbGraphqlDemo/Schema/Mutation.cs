using MongodbGraphqlDemo.Models;
using MongodbGraphqlDemo.Models.repository;

namespace MongodbGraphqlDemo.Schema
{
    public class Mutation
    {
        public bool addProduct([Service] MongoDbContext dbContext,Product entity)
        {
            dbContext.AddProducts(entity);
            return true;
        }
    }
}
