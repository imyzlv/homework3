using System;
namespace HomeWork3
{
	public class Car
	{

		public string Brand { get; set; }
		private int Speed { get; set; }
		public string NumberPlate { get; set; }
		public string Color { get; set; }

		public void Drive()
        {
			Speed = 15;
			Console.WriteLine($"Starting to drive at {Speed} km/h");
        }

		public void Stop()
        {
			Speed = 0;
			Console.WriteLine("Full stop!");
        }

		public void DriveFaster()
        {
			Speed += 10;
			Console.WriteLine($"Increasing speed to {Speed} km/h");
        }

		public void Brake()
        {
			Speed -= 10;
			if (Speed < 0)
				Speed = 0;
			Console.WriteLine($"Slowing down. Speed: {Speed} km/h");
        }

		public void SoundTheHorn()
        {
			Console.WriteLine("Beep, beep");
        }
	}
}

