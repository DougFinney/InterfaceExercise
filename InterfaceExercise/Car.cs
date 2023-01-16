using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public Car()
        {
            Year = 2020;
            EngineSize = 4.0;
        }
         public bool Hatchback { get; set; }
        public bool Convertable { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double EngineSize { get; set; }
        public string Name { get; set; }

        public string Motto { get; set; }   
        public string CorpName { get; set; }

       
    
    } 
}
