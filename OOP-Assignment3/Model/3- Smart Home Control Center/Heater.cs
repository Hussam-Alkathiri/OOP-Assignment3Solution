using OOP_Assignment3.Model.Smart_Home_Control_Center.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment3.Model.Smart_Home_Control_Center
{
    public class Heater : ISmartDevice
    {
        private bool isOn;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Heater is now ON.");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Heater is now OFF.");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Heater status: {(isOn ? "ON" : "OFF")}");
        }
    }
}
