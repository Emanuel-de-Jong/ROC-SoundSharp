using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Devices
{
    public abstract class AudioDevices
    {
        //Protected Fields
        protected int serialId;
        protected string model;
        protected string make;
        protected decimal priceExBtw;
        protected DateTime creationDate;
        protected readonly static double btwPercentage = 19.0;

        //Methodes
        public string DisplayIdentity()
        {
            return $"Serial: {serialId}";
        }

        public string DisplayIdentity(bool makeInfoInput, bool modelInfoInput)
        {
            string returnOutput = "";
            if (modelInfoInput == true)
            {
                returnOutput = $" Make: {make}";
            }
            if (makeInfoInput == true)
            {
                returnOutput += $" Model: {model}";
            }
            return returnOutput;
        }

        public string GetDeviceLifeTime()
        {
            string returnOutput;
            if (creationDate != null)
            {
                //Sets the 'returnOutput' to the current in days - the date the device was created.
                returnOutput = "Lifetime " + (DateTime.Now - creationDate).Days + " days";
            }
            else
            {
                returnOutput = "Lifetime unknown";
            }
            return returnOutput;
        }

        public abstract string DisplayStorageCapacity();

        //Properties
        public int SerialId { get { return serialId; } set { serialId = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Make { get { return make; } set { make = value; } }
        public decimal PriceExBtw { get { return priceExBtw; } set { priceExBtw = value; } }
        public DateTime CreationDate { get { return creationDate; } set { creationDate = value; } }
        //Takes the 'priceExBtw' and multiples it by 'btwPercentage' which has been defided by 100 and got added 1 to it.
        public decimal ConsumerPrice { get { return priceExBtw * Convert.ToDecimal(btwPercentage / 100 + 1); } }
    }
}
