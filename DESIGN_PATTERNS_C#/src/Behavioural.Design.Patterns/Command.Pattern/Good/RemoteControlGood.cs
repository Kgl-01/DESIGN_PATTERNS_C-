namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Command.Pattern.Good;

public class RemoteControlGood
{
    private ICommand _command;

    public RemoteControlGood(ICommand command)
    {
        _command = command;
    }


    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void PressButton()
    {
        _command.Execute();
    }

}
