using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace tardisUnitTest2
{
    public abstract class Phone
    {
        private string phoneNumber;
        public string PhoneNumber;
        public string address;

        public abstract void Connect();

        public abstract void Disconnect();
    }

    public class RotaryPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }

        public void MakeCall()
        {

        }

        public void HangUp()
        {

        }

        public override void Connect()
        {

        }

        public override void Disconnect()
        {

        }
    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        public byte WhichDrWho
        {
            get;
        }
        private string femaleSideKick;
        public string FemaleSideKick
        {
            get;
        }
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public void TimeTravel()
        {

        }
    }

    public interface PhoneInterface
    {
        void Answer();

        void MakeCall();

        void HangUp();
    }

    public class PushButtonPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }

        public void MakeCall()
        {

        }

        public void HangUp()
        {

        }

        public override void Connect()
        {

        }

        public override void Disconnect()
        {

        }

    }

    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor()
        {

        }

        public void CloseDoor()
        {

        }
    }
}
