namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Command.Pattern.Good.Undoable;

public class ItalicCommand : IUndoableCommand
{
    private HTMLDocument _document;
    private History _history;
    private string _prevContent = "";

    public ItalicCommand(HTMLDocument document, History history)
    {
        _document = document;
        _history = history;
    }

    public void Execute()
    {
        _prevContent = _document.Content;
        _document.MakeItalic(); //delegating this work to the doc business object
        _history.Push(this);
    }

    public void Unexecute()
    {
        _document.Content = _prevContent;
    }

}
