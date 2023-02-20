using VpuDotnet.Entities;
using VpuDotnet.Contexts;
using System.Text.Json;

var context = new CarContext();
// context.Create(new Car
// {
//     markName = "Ford",
//     model = "Cadette",
//     year = 1984,
//     fuel = "Petrol"
// });
// context.Create(new Car
// {
//     markName = "Opel",
//     model = "Astra",
//     year = 2013,
//     fuel ="Petrol"
// });
// context.Create(new Car
// {
//     markName = "Jeep",
//     model = "Classic",
//     year = 2001,
//     fuel = "Diesel"
// });
// context.Create(new Car
// {
//     markName = "Fiat",
//     model = "Doblo",
//     year = 2009,
//     fuel = "Diesel"
// });


var Allcars = context.GetAll();
foreach (var cars in Allcars)
Console.WriteLine($"{cars.markName}\n{cars.model}\n{cars.year}\n{cars.fuel}\n" );

context.Save();

// context.Create(new Car {
//     markName = "Ford",
//     model = "Mondeo",
//     year = 2000,
//     fuel = "Petrol"
// });
context.Save();
var upcars  = context.GetAll().FirstOrDefault(upcars =>upcars.model == "Mondeo");

upcars.fuel = "Dizel";

context.Update(upcars); 

context.Save();

var delcar = context.GetAll().FirstOrDefault(delcar =>delcar.model == "Cadette" );
context.Delete(delcar);

context.Save();
