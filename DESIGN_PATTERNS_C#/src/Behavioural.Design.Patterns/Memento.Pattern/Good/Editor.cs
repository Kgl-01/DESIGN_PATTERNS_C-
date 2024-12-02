namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Memento.Pattern.Good;

//Originator
public class Editor
{
    public string Title { get; set; }
    public string Content { get; set; }

    public EditorState CreateState()
    {
        return new EditorState(Title, Content);
    }

    public void restoreState(EditorState editorState)
    {
        Title = editorState.GetTitle();
        Content = editorState.GetContent();
    }
}
