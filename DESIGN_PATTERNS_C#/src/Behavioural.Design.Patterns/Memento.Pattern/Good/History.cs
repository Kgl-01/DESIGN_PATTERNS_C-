namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Memento.Pattern.Good;

//CareTaker
public class History
{
    private List<EditorState> _states = new List<EditorState>();
    private Editor _editor;

    public History(Editor editor)
    {
        _editor = editor;
    }


    public void BackUp()
    {
        var currentEditorState = _editor.CreateState();
        _states.Add(currentEditorState);
    }

    public void Undo()
    {
        if (_states.Count == 0) return;

        EditorState prevState = _states.Last();
        _states.Remove(prevState);
        _editor.restoreState(prevState);
    }

    public void ShowHistory()
    {
        System.Console.WriteLine("\nHistory: Here's the list of momentos:");
        foreach (var state in _states)
        {
            System.Console.WriteLine(state.GetName());
        }
    }
}
