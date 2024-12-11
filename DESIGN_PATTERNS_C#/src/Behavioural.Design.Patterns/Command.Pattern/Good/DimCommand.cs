namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Command.Pattern.Good;

public class DimCommand : ICommand
{
    private readonly LightGood _lightGood;

    public DimCommand(LightGood lightGood)
    {
        _lightGood = lightGood;
    }


    public void Execute()
    {
        _lightGood.Dim();
    }
}
