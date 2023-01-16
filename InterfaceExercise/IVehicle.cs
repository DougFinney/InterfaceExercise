using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle : ICompany
    {
        

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double EngineSize  { get; set; }
        public string Name { get; set; }
    }
}
