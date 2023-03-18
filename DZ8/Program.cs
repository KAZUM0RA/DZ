
 var cars = new Dictionary<string, Car>();
cars.Add("BI5409BВ", new Car("Toyota", "Corolla", "Красный"));
cars.Add("BC1234AH", new Car("Ford", "Mustang", "Желтый"));
cars.Add("BM5678HM", new Car("Honda", "Civic", "Голубой"));
cars.Add("BI5454PM", new Car("VAZ", "21011", "Бежевый"));
cars.Add("AA7777AK", new Car("Jeep", "Cruiser", "Красный"));
cars.Add("BI6874JH", new Car("Tesla", "Model X", "Красный"));
cars.Add("BI5678HM", new Car("Shkoda", "Fabia", "Белый"));
cars.Add("AA4869II", new Car("VAZ", "21099", "Синий"));
cars.Add("AX2455XA", new Car("Daewoo", "Matiz", "Красный"));
cars.Add("BI5845PO", new Car("Volvo", "Polestar", "Серый"));


Console.WriteLine("Все машины:");
foreach (var car in cars)
{
    Console.WriteLine($"{car.Key}: {car.Value.Manufacturer} {car.Value.Model} {car.Value.Color}");
}

Console.WriteLine("\n Машины, номера которых начинаются на BI:");
foreach (var car in cars.Where(car => car.Key.StartsWith("BI")))
{
    Console.WriteLine($"{car.Key}: {car.Value.Manufacturer} {car.Value.Model} {car.Value.Color}");
}

Console.WriteLine("\nРегистрационные номера красных машин:");
foreach (var car in cars.Where(car => car.Value.Color == "Красный"))
{
        Console.WriteLine(car.Key);
}






