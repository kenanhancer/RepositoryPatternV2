public class Customer : IEntity<int>
{
  public int Id { get; set; }
  
  public string Name { get; set; }
  
  public string Type { get; set; }
  
  public string Country { get; set; }

  public int GetId() => Id;

  public void SetId(int id) => Id = id;
}