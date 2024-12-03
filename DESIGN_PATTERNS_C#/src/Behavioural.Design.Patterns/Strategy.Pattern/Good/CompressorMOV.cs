namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Strategy.Pattern.Good;

public class CompressorMOV : ICompressor
{
    public void Compress()
    {
        System.Console.WriteLine("Compressing video using MOV");
    }

    public override string ToString()
    {
        return "mov";
    }


}
