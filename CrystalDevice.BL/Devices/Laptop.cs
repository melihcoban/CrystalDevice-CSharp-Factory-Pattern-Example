using CrystalDevice.BL.Abstract_Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalDevice.BL.Devices
{
    public class Laptop : Device
    {
        IScreenFactory screenFactory;
        public Laptop(IScreenFactory screenFactory)
        {
            DeviceName = "Crystal Laptop";
            DeviceModel = "2022";
            DeviceType = "Laptop";
            DeviceCPUArchitecture = "arm64";
            this.screenFactory = screenFactory; 
        }
        public override Screen AddScreen()
        {
            return screenFactory.CreateScreen();
        }
    }
}
