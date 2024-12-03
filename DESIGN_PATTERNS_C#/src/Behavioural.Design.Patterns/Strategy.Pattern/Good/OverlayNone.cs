namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Strategy.Pattern.Good;

public class OverlayNone : IOverlay
{
    public void Apply()
    {
        System.Console.WriteLine("Not applying overlay");
    }

}
