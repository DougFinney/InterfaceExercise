using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle....-DoNE & ICompany..._DONE

            //Create 3 classes called Car , Truck , & SUV...._DONE

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now............_DONE
             */


            //In ICompany

            /*Create 2 members that are specific to each every company.
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }.........._DONE
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members...._DONE
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var vehicle = new List<IVehicle>();

            var Sport = new Car()
            {
                Name = "Sport",
                Year = 2018,
                Make = "Honda",
                Model = "Civic",
                Hatchback = true,
                Convertable = false,
            };

            vehicle.Add(Sport);

            var Utility = new Truck()
            {
                Name = "Utility", 
                Year = 2023,
                Make = "Ford",
                Model = "F250",
                TruckBed = "Medium",
                FourWheelDrive = true, 
            };

            vehicle.Add(Utility);
            
            foreach (var veh in vehicle)
            {
                
                Console.WriteLine($"This {veh.Name} vehicle is a {veh.Year}... {veh.Make}, {veh.Model}.");
                

            }
        }
    }
}
