using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioDevices.Tracks; //Could be wrong

namespace AudioDevices.Interfaces
{
    //Holds variables with info of a display.
    interface IDisplay
    {
        string GetResolutionInfo();
        int DisplayWidth { get; set; }
        int DisplayHeight { get; set; }
        int TotalPixels { get; }
    }
    //Holds variables with info of a tracklist.
    interface ITrackList
    {
        bool HasTracks();
        void AddTrackList(TrackList trackList);
        void RemoveTrackList();

        TrackList TrackList { get; }
    }
}
