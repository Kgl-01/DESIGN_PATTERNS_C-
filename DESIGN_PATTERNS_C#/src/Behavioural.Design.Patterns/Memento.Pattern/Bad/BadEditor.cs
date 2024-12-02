namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Momento.Pattern.Bad;

public class BadEditor
{
    public string Title { get; set; }
    public Stack<string> PrevTitles { get; set; }
    public string Content { get; set; }
    public Stack<string> PrevContent { get; set; }
}
