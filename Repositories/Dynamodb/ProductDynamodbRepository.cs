public class ProductDynamodbRepository : DynamodbRepositoryBase<Product, int>, IProductRepository
{
  public ProductDynamodbRepository(IDynamodbClient dynamodbClient):base(dynamodbClient, "Product", "id")
  {}
}