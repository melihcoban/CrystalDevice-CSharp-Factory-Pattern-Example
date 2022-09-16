using CrystalDevice.BL.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalDevice.BL.Abstract_Factories
{
    public interface IScreenFactory
    {
        public Screen CreateScreen();
    }
}
