using OOP_Assignment3.Model.Smart_Home_Control_Center.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment3.Model.Smart_Home_Control_Center
{
    public class Fan : ISmartDevice
    {
        private bool isOn;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Fan is now ON.");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Fan is now OFF.");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Fan status: {(isOn ? "ON" : "OFF")}");
        }
    }
}
