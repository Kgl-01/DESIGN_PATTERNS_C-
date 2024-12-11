namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Command.Pattern.Good.Undoable;

public class UndoCommand : ICommand
{
    private History _history;

    public UndoCommand(History history)
    {
        _history = history;
    }


    public void Execute()
    {
        if (_history.Size() > 0)
        {
            var lastCommand = _history.Pop();
            lastCommand.Unexecute();
        }
    }
}
