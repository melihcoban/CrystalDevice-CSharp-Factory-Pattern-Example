using CrystalDevice.BL.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalDevice.BL.Factories
{
    public abstract class DeviceProvider
    {
        public abstract Device CreateDevice(string type);
        public Device GetDevice(string type)
        {
            Device device = CreateDevice(type);
            device.DeviceScreen = device.AddScreen();
            return device;
        }
    }
}
