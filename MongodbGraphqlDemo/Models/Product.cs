using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongodbGraphqlDemo.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
