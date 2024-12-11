namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Command.Pattern.Good.Undoable;

public interface IUndoableCommand : ICommand
{
    void Unexecute();
}
