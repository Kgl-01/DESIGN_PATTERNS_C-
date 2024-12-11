namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Command.Pattern.Bad;

public class Light
{
    //Receiver class
    public void TurnOn()
    {
        System.Console.WriteLine("Light is on.");
    }

    public void TurnOff()
    {
        System.Console.WriteLine("Light is off.");
    }

}
