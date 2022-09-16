using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalDevice.BL.Abstract_Factories
{
    public class PhoneScreenFactory : IScreenFactory
    {
        public Screen CreateScreen()
        {
            var screen = new Screen
            {
                //ScreenPanelType = Common.ScreenPanelType.VA,
                //ScreenRefreshRate = Common.ScreenRefreshRate.ScreenRefreshRate120
                ScreenPanelType = "VA",
                ScreenRefreshRate = 120
            };
            return screen;
        }
    }
}
