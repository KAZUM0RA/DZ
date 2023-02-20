namespace VpuDotnet.Entities;
// интерфейс все сущности 
public interface IEntity
{
    Guid Id { get; set; } // id
    DateTime CreatedAt { get; set; } // время создания 
}