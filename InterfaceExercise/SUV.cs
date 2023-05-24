﻿using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int NumberOfWheels { get; set; }
        public bool PowerWindows { get; set; }

        public string Logo { get; set; }
        public string Motto { get; set; }
        public string Location { get; set; }

        public double CargoHoldSize { get; set; }
        public int NumberOfSeats { get; set; }

        public void VehicleDetails()
        {
            Console.WriteLine($"Hey there, folks! Are you in the market for a sweet {Make} {Model} {Year}? \n" +
                $"Well, have I got a deal for you! \n" +
                $"Feast your eyes on this jaw-dropping beauty with {NumberOfWheels} wheels and {PowerWindows}ly powerful windows. \n" +
                $"We've got ourselves an SUV that's as fast as a shark and as powerful as a earthquake, living up to {Make}'s motto' '{Motto}.' \n" +
                $"Let's dive right into the features that'll have you drooling in no time. \n" +
                $"Made in {Location}, this SUV boasts a cargo hold size of {CargoHoldSize} sqft that will make your neighbors jealous. \n" +
                $"Finally, with {NumberOfSeats} seats, you can carry an entire basketball team to practice!");
        }

    }
}
