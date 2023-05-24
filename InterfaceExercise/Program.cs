using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
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
