using CrystalDevice.BL.Abstract_Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalDevice.BL.Devices
{
    public abstract class Device
    {
        public string DeviceName { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceType { get; set; }
        public string DeviceCPUArchitecture { get; set; }
        public Screen DeviceScreen { get; set; }
        public virtual string AddComponents()
        {
            return "Adding components...";
        }
        public abstract Screen AddScreen();
        public virtual string AddBody()
        {
            return "Adding body...";
        }
        public virtual string CreateProduct()
        {
            return "Product is created."; 
        }

    }
}
