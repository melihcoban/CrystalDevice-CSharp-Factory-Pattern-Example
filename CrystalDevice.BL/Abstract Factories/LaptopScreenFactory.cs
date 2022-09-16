using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalDevice.BL.Abstract_Factories
{
    public class LaptopScreenFactory : IScreenFactory
    {
        public Screen CreateScreen()
        {
            var screen = new Screen
            {
                //ScreenPanelType = Common.ScreenPanelType.IPS,
                //ScreenRefreshRate = Common.ScreenRefreshRate.ScreenRefreshRate144
                ScreenPanelType = "IPS",
                ScreenRefreshRate = 144
            };
            return screen;
        }
    }
}
