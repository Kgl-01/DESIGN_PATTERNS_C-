namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Strategy.Pattern.Bad;

public class VideoStorageBad
{
    private Compressors _compressor;
    private Overlays _overlay;

    public VideoStorageBad(Compressors compressor, Overlays overlay = Overlays.None)
    {
        _compressor = compressor;
        _overlay = overlay;
    }

    public void SetCompressor(Compressors compressor)
    {
        _compressor = compressor;
    }

    public void SetOverlay(Overlays overlay)
    {
        _overlay = overlay;
    }

    public void Store(string fileName)
    {
        //Compressor logic
        if (_compressor == Compressors.MOV)
        {
            System.Console.WriteLine("Compressing using MOV");
        }
        else if (_compressor == Compressors.MP4)
        {
            System.Console.WriteLine("Compressing using MP4");
        }
        else if (_compressor == Compressors.WEBM)
        {
            System.Console.WriteLine("Compressing using WEBM");
        }

        //Overlay Logic
        if (_overlay == Overlays.None)
        {
            System.Console.WriteLine("Not applying any overlay.");
        }
        else if (_overlay == Overlays.BlackAndWhite)
        {
            System.Console.WriteLine("Appying black and white overlay.");
        }
        else if (_overlay == Overlays.Blur)
        {
            System.Console.WriteLine("Appying blur overlay.");
        }

        System.Console.WriteLine($"Storing video to {fileName}.{_compressor}");
    }
}
