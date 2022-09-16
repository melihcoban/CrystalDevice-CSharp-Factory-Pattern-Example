using CrystalDevice.BL.Abstract_Factories;
using CrystalDevice.BL.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalDevice.BL.Factories
{
    public class LaptopFactory : DeviceProvider
    {
        IScreenFactory screenFactory = new LaptopScreenFactory();
        public override Device CreateDevice(string type)
        {
            return new Laptop(screenFactory);
        }
    }
}
