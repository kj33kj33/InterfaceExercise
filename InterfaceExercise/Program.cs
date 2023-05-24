using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car gTR = new Car()
            {
                Make = "Nissan",
                Model = "GTR",
                Year = 2015,
                NumberOfWheels = 4,
                PowerWindows = true,
                Logo = "The company name, Nissan, in front of the sun",
                Motto = "Innovation That Excites",
                Location = "Japan",
                TrunkSize = 8.8,
                HasSpoiler = true
            };

            Truck ram = new Truck()
            {
                Make = "Dodge",
                Model = "Ram",
                Year = 2020,
                NumberOfWheels = 6,
                PowerWindows = true,
                Logo = "A ram's head",
                Motto = "Guts. Glory. Ram",
                Location = "USA",
                BedSize = 76.8,
                LiftHeight = 10
            };

            SUV rav4 = new SUV()
            {
                Make = "Toyota",
                Model = "RAV 4",
                Year = 2017,
                NumberOfWheels = 4,
                PowerWindows = true,
                Logo = "An oval with a T drawn with smaller ovals",
                Motto = "Let's Go Places",
                Location = "Canada",
                CargoHoldSize = 38.4,
                NumberOfSeats = 5
            };

            gTR.VehicleDetails();
            Console.WriteLine("\n======================================\n");
            ram.VehicleDetails();
            Console.WriteLine("\n======================================\n");
            rav4.VehicleDetails();

        }
    }
}
