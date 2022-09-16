using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDevice.BL;
using CrystalDevice.BL.Abstract_Factories;
using CrystalDevice.BL.Factories;

namespace CrystalDevice.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeviceProvider deviceProviderFactory;
            Console.Write("Device Type: ");
            var deviceType = Console.ReadLine();
            var factoryProvider = new DeviceFactoryProvider();
            deviceProviderFactory = factoryProvider.CreateFactoryFor(deviceType);

            if (deviceProviderFactory == null)
            {
                throw new NotSupportedException("This device does not exists.");
            }
            var device = deviceProviderFactory.GetDevice(deviceType);
            Console.WriteLine($"Name: {device.DeviceName}\r\nModel: {device.DeviceModel}\r\nCPU Architecture: {device.DeviceCPUArchitecture}\r\n" +
                $"Screen Panel Type: {device.DeviceScreen.ScreenPanelType}\r\nScreen Refresh Rate: {device.DeviceScreen.ScreenRefreshRate}Hz");
            Console.ReadLine();

        }
    }
}
