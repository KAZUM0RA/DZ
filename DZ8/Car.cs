public class Car
{
    public string? Manufacturer { get; set; }
    public string? Model { get; set; }
    public string? Color { get; set; }
  public Car(string manufacturer, string model, string color)
    {
        Manufacturer = manufacturer;
        Model = model;
        Color = color;
    }
}