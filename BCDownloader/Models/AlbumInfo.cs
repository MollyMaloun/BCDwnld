﻿using Newtonsoft.Json;
using System.Collections.Concurrent;

namespace BCDownloader.Models
{
    public record AlbumInfo(
        [JsonProperty("artist")]
        string? Artist,
        [JsonProperty("album_release_date")]
        string? ReleaseDate,
        [JsonProperty("trackinfo")]
        ConcurrentBag<Trackinfo>? TrackInfo)
    {
        public byte[]? CoverData { get; set; }
    }
}
