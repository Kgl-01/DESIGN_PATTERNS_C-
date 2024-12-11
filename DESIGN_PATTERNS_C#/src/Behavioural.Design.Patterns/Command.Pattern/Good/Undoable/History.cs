namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Command.Pattern.Good.Undoable;

public class History
{
    private List<IUndoableCommand> _undoableCommands = new List<IUndoableCommand>();

    public void Push(IUndoableCommand command)
    {
        _undoableCommands.Add(command);
    }

    public IUndoableCommand Pop()
    {
        var last = _undoableCommands.Last();
        _undoableCommands.Remove(last);
        return last;
    }

    public int Size()
    {
        return _undoableCommands.Count;
    }
}
