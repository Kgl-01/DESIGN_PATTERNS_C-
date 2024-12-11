namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Command.Pattern.Good.Undoable;

public class HTMLDocument
{
    public string Content { get; set; }

    public void MakeItalic()
    {
        Content = $"<i>{Content}</i>";
    }
}
