using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment3.Model.Smart_Home_Control_Center.Interface
{
    public interface ISmartDevice
    {
        void TurnOn();
        void TurnOff();
        void ShowStatus();
    }
}
