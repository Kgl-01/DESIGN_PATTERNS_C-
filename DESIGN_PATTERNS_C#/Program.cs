//Inheritence

using DESIGN_PATTERNS_C_.src.OOP_Principles.Inheritence;

List<Vehicle> vehicles = new List<Vehicle>();

vehicles.Add(new Car { Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4 });
vehicles.Add(new Bike { Brand = "Bajaj", Model = "Pulsar 200NS", Year = 2018 });


//vehicle inspection

foreach (var vehicle in vehicles)
{
    System.Console.WriteLine(typeof(Vehicle).Name);
}

