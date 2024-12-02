namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Memento.Pattern.Good;

//Momento
public class EditorState
{
    private readonly string _title;
    private readonly string _content;
    //State meta Data
    private readonly DateTime _stateCreatedAt;

    public EditorState(string title, string content)
    {
        _title = title;
        _content = content;
        _stateCreatedAt = DateTime.Now;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetContent()
    {
        return _content;
    }

    public DateTime GetCreateDate()
    {
        return _stateCreatedAt;
    }

    public string GetName()
    {
        return $"{_stateCreatedAt} / {_title}";
    }
}
