namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.State.Pattern.Good;

public class Document
{
    private IState _state;
    public UserRoles CurrentUserRole { get; set; }

    public Document(UserRoles currentUserRole)
    {
        _state = new DraftState(this);
        CurrentUserRole = currentUserRole;
    }

    public void Publish()
    {
        _state.Publish();
    }

    public void SetState(IState state)
    {
        _state = state;
    }

}
