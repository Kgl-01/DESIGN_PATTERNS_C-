namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Command.Pattern.Good;

public class TurnOffCommand : ICommand
{
    private readonly LightGood _lightGood;

    public TurnOffCommand(LightGood lightGood)
    {
        _lightGood = lightGood;
    }


    public void Execute()
    {
        _lightGood.TurnOff();
    }

}
