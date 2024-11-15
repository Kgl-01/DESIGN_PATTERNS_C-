namespace DESIGN_PATTERNS_C_.src.OOP_Principles.Inheritence;

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    public int NumberOfWheels { get; set; }

    public override void Start()
    {
        System.Console.WriteLine("Car is starting");
    }

    public override void Stop()
    {
        System.Console.WriteLine("Car is stopping");
    }
}
