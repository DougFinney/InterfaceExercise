using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public SUV()
        {
            Year = 2022;
            EngineSize = 6.0;
        }
        public bool ThirdRow { get; set; }
        public bool BackUpCamera { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double EngineSize { get; set; }
        public string Name { get; set; }

        public string Motto { get; set; }   
        public string CorpName { get; set; }

      
        
    }
}
