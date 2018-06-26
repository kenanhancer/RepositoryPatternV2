public class ProductDatabaseRepository : DatabaseRepositoryBase<Product, int>, IProductRepository
{
  public ProductDatabaseRepository(IOrm orm) : base(orm, "product", "id")
  {
  }
}