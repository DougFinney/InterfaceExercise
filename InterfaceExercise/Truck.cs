using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public Truck()
        {
            Year = 2012;
            EngineSize = 8.0;
        }
        public string TruckBed { get; set; }
        public bool FourWheelDrive { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double EngineSize { get; set; }
        public string Name { get; set; }

        public string Motto { get; set; }    
        public string CorpName { get; set; }

     
    }
}
