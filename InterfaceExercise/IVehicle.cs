using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle : ICompany
    {
        public int Tires { get; set; }
        public string Motor { get; set; }
        public string Seats { get; set; }
        public string Accelerator { get; set; }
    }
}
