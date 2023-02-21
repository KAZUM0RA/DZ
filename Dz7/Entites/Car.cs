namespace VpuDotnet.Entities;
public class Car : IEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; set; } // время создания 
    public string? markName { get; set; }
    public string? model { get; set; }
    public int year { get; set; }
    public string? fuel {get; set;}

}
