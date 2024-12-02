namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.State.Pattern.Bad;

public class DocumentBad
{
    public DocumentStates State { get; set; }
    public UserRoles CurrentUserRole { get; set; }

    public void Publish()
    {
        if (State == DocumentStates.Draft)
        {
            State = DocumentStates.Moderation;
        }
        else if (State == DocumentStates.Moderation)
        {
            if (CurrentUserRole == UserRoles.Admin)
            {
                State = DocumentStates.Publish;
            }
        }
        else if (State == DocumentStates.Publish)
        {
            // do nothing
            //redundant else if
        }
    }
}
