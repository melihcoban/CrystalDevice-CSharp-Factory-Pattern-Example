using CrystalDevice.BL.Abstract_Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalDevice.BL.Devices
{
    public class Tablet : Device
    {
        IScreenFactory screenFactory;
        public Tablet(IScreenFactory screenFactory)
        {
            DeviceName = "Crystal Tablet";
            DeviceModel = "2015";
            DeviceType = "Tablet";
            DeviceCPUArchitecture = "x86";
            this.screenFactory = screenFactory;
        }
        public override Screen AddScreen()
        {
            return screenFactory.CreateScreen();
        }
    }
}
