using MongodbGraphqlDemo.Models;

namespace MongodbGraphqlDemo.Schema
{
    public class ProductType:ObjectType<Product>
    {
        protected override void Configure(IObjectTypeDescriptor<Product> descriptor)
        {
            descriptor.Field(p => p.Id).Type<IdType>();
            descriptor.Field(p => p.Name).Type<StringType>();
            // Define other fields and relationships here
            //Commented
        }
    }
}
