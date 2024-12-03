namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Strategy.Pattern.Good;

public class CompressorMP4 : ICompressor
{
    public void Compress()
    {
        System.Console.WriteLine("Compressing video using MP4.");
    }

    public override string ToString()
    {
        return "mp4";
    }

}
