using VpuDotnet.Entities;
using VpuDotnet.Contexts;
using System.Text.Json;

var context = new CarContext();
context.Create(new Car
{
    markName = "Ford",
    model = "Cadette",
    year = 1984,
});
context.Create(new Car
{
    markName = "Opel",
    model = "Astra",
    year = 2013,
});
context.Create(new Car
{
    markName = "Jeep",
    model = "Classic",
    year = 2001,
});
context.Create(new Car
{
    markName = "Fiat",
    model = "Doblo",
    year = 2009,
});


var Allcars = context.GetAll();
foreach (var cars in Allcars)
Console.WriteLine($"{cars.markName}\n{cars.model}\n{cars.year}\n" );