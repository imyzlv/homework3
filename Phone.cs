using System;
namespace HomeWork3
{
	public class Phone
	{

		public string Brand { get; set; }

		public string Model { get; set; }

		public string Size { get; set; }

		public void Call(string phoneNumber)
        {
			Console.WriteLine($"Calling to {phoneNumber}");
        }

		public void SendSMS(string phoneNumber, string smsText)
        {
			Console.WriteLine($"Sending: {smsText} to {phoneNumber}");
        }

	}
}

