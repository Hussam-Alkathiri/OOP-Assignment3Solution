using OOP_Assignment3.Model.Smart_Home_Control_Center.Enum;
using OOP_Assignment3.Model.Smart_Home_Control_Center.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment3.Model.Smart_Home_Control_Center
{
    public class SmartHome
    {
        private ISmartDevice[] devices = new ISmartDevice[4];

        public SmartHome()
        {
            devices[(int)DeviceType.Light] = new Light();
            devices[(int)DeviceType.Fan] = new Fan();
            devices[(int)DeviceType.AC] = new AC();
            devices[(int)DeviceType.Heater] = new Heater();
        }
        public ISmartDevice this[DeviceType type]
        {
            get { return devices[(int)type]; }
        }
    }
}
