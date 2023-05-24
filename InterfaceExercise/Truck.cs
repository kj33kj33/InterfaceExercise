using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
    {
		public Truck()
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

        public double BedSize { get; set; }
        public int LiftHeight { get; set; }

        public void VehicleDetails()
        {
            Console.WriteLine($"Hey there, folks! Are you in the market for a sweet {Make} {Model} {Year}? \n" +
                $"Well, have I got a deal for you! \n" +
                $"Feast your eyes on this jaw-dropping beauty with {NumberOfWheels} wheels and {PowerWindows}ly powerful windows. \n" +
                $"We've got ourselves a truck that's as fast as an eagle and as powerful as a tornado, living up to {Make}'s motto' '{Motto}.' \n" +
                $"Let's dive right into the features that'll have you drooling in no time. \n" +
                $"Made in {Location}, this truck boasts a bed size of {BedSize} inches that will make your neighbors jealous. \n" +
                $"Finally, with a {LiftHeight} inch lift you'll sitting eye to eye with a Elephant.");
        }

    }
}

