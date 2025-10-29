using OOP_Assignment3.Model.Smart_Home_Control_Center.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment3.Model.Smart_Home_Control_Center
{
    public class Light : ISmartDevice
    {
        bool isOn;
        public void ShowStatus()
        {
            Console.WriteLine($"Light status: {(isOn ? "ON" : "OFF")}");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Light is Off");
        }

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Light is on");
        }
    }
}
