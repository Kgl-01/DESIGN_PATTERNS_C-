namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Strategy.Pattern.Good;

public class OverlayBlur : IOverlay
{
    public void Apply()
    {
        System.Console.WriteLine("Applying blur overlay");
    }

}
