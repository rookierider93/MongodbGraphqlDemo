using MongoDB.Driver;

namespace MongodbGraphqlDemo.Models.repository
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MongoDB");
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase("TestDatabase");
        }
        public IMongoCollection<Product> Products => _database.GetCollection<Product>("Products");

        public bool AddProducts(Product entity)
        {
             _database.GetCollection<Product>("Products").InsertOne(entity);
            return true;
        }
    }
}
