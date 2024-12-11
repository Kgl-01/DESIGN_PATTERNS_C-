namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Command.Pattern.Good;

public class LightGood
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

    public void Dim()
    {
        System.Console.WriteLine("Light is dim");
    }
}
