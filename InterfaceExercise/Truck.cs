﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle
    {
        public string TruckBed { get; set; }
        public bool FourWheelDrive { get; set; }
        public int Tires { get; set; }
        public string Motor { get; set; }
        public string Seats { get; set; }
        public string Accelerator { get; set; }
        public string CompanyProfit { get; set; }
        public string CompanyName { get; set; }
    }
}
