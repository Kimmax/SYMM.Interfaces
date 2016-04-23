using System;
using System.Drawing;

namespace SYMM.Interfaces
{
    public interface IYouTubeVideo
    {
        Bitmap GetThumbnail();
        DateTime? PublishDate { get; }

        long? PlayListPos { get; }
        
        string Desc { get; }
        string GetWatchID();
        string ThumbURL { get; }
        string VideoTitle { get; }
        string ChannelTitle { get; }
        string VideoWatchID { get; }
    }
}