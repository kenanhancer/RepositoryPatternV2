public class Product : IEntity<int>
{
  public int Id { get; set; }
  
  public string Name { get; set; }
  
  public double Price { get; set; }

  public int GetId() => Id;

  public void SetId(int id) => Id = id;
}