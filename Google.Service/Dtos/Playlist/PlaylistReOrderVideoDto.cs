using System;

namespace Google.Service.Dtos.Playlist
{
    public class PlaylistReOrderVideoDto
    {
        public Guid VideoId { get; set; }
        public Guid PlaylistId { get; set; }
        public int NewOrder { get; set; }
    }
}