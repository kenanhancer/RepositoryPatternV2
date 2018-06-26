public interface IEntity<TKey>
{
  TKey GetId();
  void SetId(TKey id);
}