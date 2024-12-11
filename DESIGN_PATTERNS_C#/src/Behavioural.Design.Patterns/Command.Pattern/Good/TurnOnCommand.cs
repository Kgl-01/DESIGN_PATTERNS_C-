namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Command.Pattern.Good;

public class TurnOnCommand : ICommand
{
    private readonly LightGood _goodLight;

    public TurnOnCommand(LightGood goodLight)
    {
        _goodLight = goodLight;
    }

    public void Execute()
    {
        _goodLight.TurnOn();
    }
}
