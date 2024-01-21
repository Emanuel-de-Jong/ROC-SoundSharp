using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Devices
{
    public class MemoRecorder : AudioDevices
    {
        //Private Fields 
        private MemoCatridgeType maxCatridgeType = MemoCatridgeType.Unknown;

        public MemoRecorder(int serialIdInput)
        {
            serialId = serialIdInput;
        }

        //Looks which type 'maxCartridgeType' is and returns it to the user.
        public override string DisplayStorageCapacity()
        {
            string displayStorageCapacity = "";
            switch (maxCatridgeType)
            {
                case MemoCatridgeType.C60:
                    displayStorageCapacity = "Max capacity 60 min.";
                    break;
                case MemoCatridgeType.C90:
                    displayStorageCapacity = "Max capacity 90 min.";
                    break;
                case MemoCatridgeType.C120:
                    displayStorageCapacity = "Max capacity 120 min.";
                    break;
                case MemoCatridgeType.Unknown:
                    displayStorageCapacity = "Max capacity unknown";
                    break;
            }
            return displayStorageCapacity;
        }

        //Properties
        public MemoCatridgeType MaxCartridgeType { get { return maxCatridgeType; } set { maxCatridgeType = value; } }
    }

    //Defines an enum with all 'maxCartridgeType' types.
    public enum MemoCatridgeType { C60,C90,C120,Unknown };
}
