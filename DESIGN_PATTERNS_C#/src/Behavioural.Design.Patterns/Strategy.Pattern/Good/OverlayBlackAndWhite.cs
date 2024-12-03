namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Strategy.Pattern.Good;

public class OverlayBlackAndWhite : IOverlay
{
    public void Apply()
    {
        System.Console.WriteLine("Applying black and white overlay");
    }

}
