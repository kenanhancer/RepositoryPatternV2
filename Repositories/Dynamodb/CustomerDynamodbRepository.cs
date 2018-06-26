public class CustomerDynamodbRepository : DynamodbRepositoryBase<Customer, int>, ICustomerRepository
{
  public CustomerDynamodbRepository(IDynamodbClient dynamodbClient):base(dynamodbClient, "Customer", "id")
  {}
}