namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.State.Pattern.Good;

public class PublishState : IState
{
    private Document _document;

    public PublishState(Document document)
    {
        _document = document;
    }

    public void Publish()
    {
        //do nothing if already in published state
    }

}
