namespace DESIGN_PATTERNS_C_.src.OOP_Principles.Inheritence;

public class Bike : Vehicle
{
    int NumberOfWheels { get; set; }
    public override void Start()
    {
        System.Console.WriteLine("Motor-Bike is starting");
    }

    public override void Stop()
    {
        System.Console.WriteLine("Motor-Bike is stopping");
    }
}
