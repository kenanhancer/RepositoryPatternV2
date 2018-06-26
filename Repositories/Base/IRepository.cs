public interface IRepository<TEntity, TKey> where TEntity : class, IEntity<TKey>, new()
{
  TEntity GetById(TKey id);
  void Create(TEntity entity);
  void Update(TEntity entity);
  void Delete(TEntity entity);
}