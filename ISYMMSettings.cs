namespace SYMM.Interfaces
{
    public enum AudioFormats
    {
        mp3,
        wav,
        m4a,
        wma,
        ogg
    }

    public enum Actions
    {
        Download,
        ExtractAudio,
        Stream
    }

    public enum Mode
    {
        Single,
        All
    }

    public struct URLSpecs
    {
        public bool IsPlaylist;
        public bool ContainsVideo;

        public URLSpecs(string url)
        {
            URLSpecs specs = URLSpecs.ExamineURL(url);
            this.IsPlaylist = specs.IsPlaylist;
            this.ContainsVideo = specs.ContainsVideo;
        }

        public URLSpecs(bool IsPlaylist, bool ContainsVideo)
        {
            this.IsPlaylist = IsPlaylist;
            this.ContainsVideo = ContainsVideo;
        }

        public static URLSpecs ExamineURL(string url)
        {
            return new URLSpecs(url.Contains("list="), url.Contains("watch?v="));
        }
    }

    public interface ISYMMSettings
    {
        Actions Action { get; }
        Mode DownloadMode { get; }
        AudioFormats AudioFormat { get; }

        URLSpecs UrlSpecs { get; }

        bool CheckDuplicate { get; }

        short VideoResolution { get; }
        short AudioBitrate { get; }
       
        string DownloadURL { get; }
        string PathSafefileName { get; set; }
        string SavePath { get; }
        string AlbumNameRegex { get; }
    }
}