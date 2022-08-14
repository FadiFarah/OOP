using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_1
{
    class Vehicle
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int NumOfDoors { get; set; }
        public int NumOfWheels { get; set; }

        public Vehicle(string model, string manufacturer, int numOfDoors, int numOfWheels)
        {
            Model = model;
            Manufacturer = manufacturer;
            NumOfDoors = numOfDoors;
            NumOfWheels = numOfWheels;
        }
    }
}
