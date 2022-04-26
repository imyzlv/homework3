using System;
namespace HomeWork3
{
	public class Person
	{
		public Person()
		{
		}
		public string Name { get; set; }
		public string Surname { get; set; }
		public DateTime BirthDate { get; set; }
		public string Hobby { get; set; }
		public bool Gender { get; set; } //true for male

		public void PrintHello()
        {
			int age = DateTime.Now.Year - BirthDate.Year;
			if (BirthDate > DateTime.Now.AddYears(-age))
				age--;
            Console.WriteLine($"Hello my name is {Name} {Surname} and I am {age} old");
        }
	}
}

