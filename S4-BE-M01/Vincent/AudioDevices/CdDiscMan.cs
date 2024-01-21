using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioDevices.Interfaces;

namespace AudioDevices.Devices
{
    public class CdDiscMan : AudioDevices, IDisplay
    {
        //Private Fields
        private readonly int mBSize = 700;
        private int displayWidth;
        private int displayHeight;
        private bool isEjected = false;

        //Constructors
        public CdDiscMan(int serialIdInput)
        {
            serialId = serialIdInput;
        }

        //Methodes
        public string GetResolutionInfo()
        {
            return $"Resolution: {TotalPixels} pixels.";
        }

        public override string DisplayStorageCapacity()
        {
            return $"{mBSize} mB.";
        }

        public bool Eject()
        {
            if (isEjected == true)
            {
                isEjected = false;
            }
            else
            {
                isEjected = true;
            }
            return isEjected;
        }

        //Properties
        public int MbSize { get { return mBSize; } }
        public int DisplayWidth { get { return displayWidth; } set { displayWidth = value; } }
        public int DisplayHeight { get { return displayHeight; } set { displayHeight = value; } }
        public int TotalPixels { get { return displayWidth* displayHeight; } }
        public bool IsEjected { get { return isEjected; } }
    }
}
