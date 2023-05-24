using System;
namespace InterfaceExercise
{
	public class Car : IVehicle, ICompany
	{
		public Car()
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

        public double TrunkSize { get; set; }
        public bool HasSpoiler { get; set; }

        public void VehicleDetails()
        {
            Console.WriteLine($"Hey there, folks! Are you in the market for a sweet {Make} {Model} {Year}? \n" +
                $"Well, have I got a deal for you! \n" +
                $"Feast your eyes on this jaw-dropping beauty with {NumberOfWheels} wheels and {PowerWindows}ly powerful windows. \n" +
                $"We've got ourselves a car that's as sleek as a panther and as powerful as a hurricane, living up to {Make}'s motto' '{Motto}.' \n" +
                $"Let's dive right into the features that'll have you drooling in no time. \n" +
                $"Made in {Location}, this car boasts a trunk size of {TrunkSize} sqft that will make your neighbors jealous. \n" +
                $"Finally, it is {HasSpoiler} this car has a spoiler, improving aerodynamics and making it faster than a cheetah.");
        }
    }
}

