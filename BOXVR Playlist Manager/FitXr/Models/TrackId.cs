﻿using System.IO;
using BoxVR_Playlist_Manager.FitXr.Utility;
using Newtonsoft.Json;

namespace BoxVR_Playlist_Manager.FitXr.Models
{
    public class TrackId
    {
        public TrackId()
        {
        }
        public TrackId(string fullFilePath)
        {
            if(fullFilePath.Contains("/TrackData/"))
                this.trackId = Path.GetFileNameWithoutExtension(fullFilePath);
            else
                this.trackId = MD5.MD5Sum(Path.GetFileNameWithoutExtension(fullFilePath));
        }

        [JsonProperty("trackId")]
        public string trackId { get; set; }
    }
}
