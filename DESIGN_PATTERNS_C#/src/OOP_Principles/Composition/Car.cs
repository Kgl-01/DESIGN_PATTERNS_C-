namespace DESIGN_PATTERNS_C_.src.OOP_Principles.Composition;

public class Car
{
    private Engine engine = new Engine();
    private Wheels wheels = new Wheels();
    private Chasis chasis = new Chasis();
    private Seats seats = new Seats();


    public void StartCar()
    {
        engine.Start();
        wheels.Rotate();
        seats.Sit();
        chasis.Support();
    }
}
