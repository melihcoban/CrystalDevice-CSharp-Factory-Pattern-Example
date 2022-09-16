using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalDevice.BL.Abstract_Factories
{
    public class TabletScreenFactory : IScreenFactory
    {
        public Screen CreateScreen()
        {
            var screen = new Screen
            {
                //ScreenPanelType = Common.ScreenPanelType.TN,
                //ScreenRefreshRate = Common.ScreenRefreshRate.ScreenRefreshRate60
                ScreenPanelType = "TN",
                ScreenRefreshRate = 60
            };
            return screen;
        }
    }
}
