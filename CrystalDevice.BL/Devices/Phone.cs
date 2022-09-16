using CrystalDevice.BL.Abstract_Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalDevice.BL.Devices
{
    public class Phone : Device
    {
        IScreenFactory screenFactory;
        public Phone(IScreenFactory screenFactory)
        {
            DeviceName = "Crystal Phone";
            DeviceModel = "2018";
            DeviceType = "Phone";
            DeviceCPUArchitecture = "x64";
            this.screenFactory = screenFactory;
        }
        public override Screen AddScreen()
        {
            return screenFactory.CreateScreen();
        }
    }
}
