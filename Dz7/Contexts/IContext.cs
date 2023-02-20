using VpuDotnet.Entities;
namespace VpuDotnet.Contexts;

// Интерфейс контекстов без данніх
// т - тип данніх сущности
// where Т IEntity  значит что типом е могут 
public interface IContext<T> where T : IEntity
{

    void Create(T entity);

    void Update(T entity);

    void Delete(Guid id);

    void Delete(T entity);
    // получить все сущности 
    IEnumerable<T> GetAll();
}