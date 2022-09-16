using CrystalDevice.BL.Abstract_Factories;
using CrystalDevice.BL.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CrystalDevice.BL
{
    public class DeviceFactoryProvider
    {
        private IEnumerable<Type> factories;

        public DeviceFactoryProvider()
        {
            factories = Assembly.GetAssembly(typeof(DeviceFactoryProvider))
                .GetTypes()
                .Where(t => typeof(DeviceProvider).IsAssignableFrom(t));
        }

        public DeviceProvider CreateFactoryFor(string name)
        {
            var factory = factories.Single(x =>
                x.Name.ToLowerInvariant().Contains(name.ToLowerInvariant()));

            return (DeviceProvider)Activator.CreateInstance(factory);
        }
    }
}
