namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.State.Pattern.Good;

public class DraftState : IState
{
    private Document _document;

    public DraftState(Document document)
    {
        _document = document;
    }


    public void Publish()
    {
        _document.SetState(new ModerationState(_document));
    }

}
