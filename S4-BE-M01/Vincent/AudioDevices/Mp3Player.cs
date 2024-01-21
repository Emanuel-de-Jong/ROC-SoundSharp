using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioDevices.Interfaces;
using AudioDevices.Tracks;
using System.Drawing;

namespace AudioDevices.Devices
{
    public class Mp3Player : AudioDevices, IDisplay, ITrackList
    {
        //Private Fields.

        private TrackList trackList;
        private int mBSize = 0;
        private int displayWidth;
        private int displayHeight;
        private int totalpixels;

        //Constructors.

        public Mp3Player(int serialIdInput)
        {
            serialId = serialIdInput;
        }

        //Methodes.

        public string GetResolutionInfo()
        {
            totalpixels = displayWidth * displayHeight;
            return "Resolution: [totalpixels] pixels.";
        }
        //Checks if their are tracks in the tracklist.
        public bool HasTracks()
        {
            if (trackList.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Adds a tracklist.
        public void AddTrackList(TrackList trackListInput)
        {
            trackList = trackListInput;
        }
        //Clears the tracklist.
        public void RemoveTrackList()
        {
            trackList.Clear();
        }
        //Displays the track size.
        public override string DisplayStorageCapacity()
        {
            if (mBSize <= 0)
            {
                return "Storage capacity unknown.";
            }
            else
            {
                return $"{mBSize} mB.";
            }
        }

        //Properties.
        public int MbSize { get { return mBSize; } set { mBSize = value; } }
        public int DisplayWidth { get { return displayWidth; } set { displayWidth = value; } }
        public int DisplayHeight { get { return displayHeight; } set { displayHeight = value; } }
        public int TotalPixels { get { return displayHeight * displayWidth; } }
        public TrackList TrackList { get { return trackList; } }

    }
}
