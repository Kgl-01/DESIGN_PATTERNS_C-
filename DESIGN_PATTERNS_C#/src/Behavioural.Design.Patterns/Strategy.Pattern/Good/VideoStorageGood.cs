namespace DESIGN_PATTERNS_C_.src.Behavioural.Design.Patterns.Strategy.Pattern.Good
{

    public class VideoStorageGood
    {
        private ICompressor _compressor;
        private IOverlay _overlay;

        public VideoStorageGood(ICompressor compressor, IOverlay overlay)
        {
            _compressor = compressor;
            _overlay = overlay;
        }


        public void SetCompressor(ICompressor compressor)
        {
            _compressor = compressor;
        }

        public void SetOverlay(IOverlay overlay)
        {
            _overlay = overlay;
        }


        public void Store(string fileName)
        {
            _compressor.Compress();
            _overlay.Apply();

            System.Console.WriteLine($"Storing video to {fileName}.{_compressor}");
        }

    }
}
