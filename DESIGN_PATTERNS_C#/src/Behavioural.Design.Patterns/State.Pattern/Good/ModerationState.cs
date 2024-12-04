namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.State.Pattern.Good;

public class ModerationState : IState
{
    private Document _document;

    public ModerationState(Document document)
    {
        _document = document;
    }


    public void Publish()
    {

        if (_document.CurrentUserRole == UserRoles.Admin)
        {
            _document.SetState(new PublishState(_document));
        }
    }
}
