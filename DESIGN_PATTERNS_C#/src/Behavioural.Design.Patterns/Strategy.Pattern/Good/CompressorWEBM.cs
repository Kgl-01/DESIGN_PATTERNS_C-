namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Strategy.Pattern.Good;

public class CompressorWebm : ICompressor
{
    public void Compress()
    {
        System.Console.WriteLine("Compressing video using Webm");
    }
    public override string ToString()
    {
        return "webm";
    }

}
