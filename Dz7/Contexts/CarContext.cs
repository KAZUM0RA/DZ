using VpuDotnet.Entities;
using System.Text.Json;
namespace VpuDotnet.Contexts;


public class CarContext : IContext<Car>
{
    private string _fileNameCar = "cars.json";
    
    private List<Car> _car;
    public CarContext()
    {
        if (!File.Exists(_fileNameCar))
        {
            File.Create(_fileNameCar);
        }
        var reader = new StreamReader(_fileNameCar);

        string fileContent = reader.ReadToEnd();
        reader.Close();
        if (fileContent.Length < 2)
        {
            _car = new List<Car>();
        }
        else
        {
            _car = JsonSerializer.Deserialize<List<Car>>(fileContent);
        }
    }
    public void Save()
    {
        string json = JsonSerializer.Serialize(_car);
        var write = new StreamWriter(_fileNameCar);
        write.Write(json);
        write.Close();
    }
    public void Create(Car entity)
    {
        _car.Add(entity);
    }

    public void Delete(Guid id)
    {
        _car.RemoveAll(car => car.Id == id);

    }

    public void Delete(Car entity)
    {
        Delete(entity.Id);
    }

    public IEnumerable<Car> GetAll()
    {
        
        return _car;

    }

    public void Update(Car entity)
    {
        var car = _car.FirstOrDefault(car => car.Id == entity.Id);
        if (car is null)
            throw new ArgumentException("error");
        car.markName = entity.markName;
        car.model = entity.model;
        car.year = entity.year;
    }
}