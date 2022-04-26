using HomeWork3;

//----------  1st task  ----------
Phone firstPhone = new Phone();
firstPhone.Brand = "Samsung";
firstPhone.Model = "Fliphone";
firstPhone.Size = "100x120x12";
firstPhone.Call("232223221");
firstPhone.SendSMS("242423", "Hello world!");

Phone secondPhone = new Phone();
secondPhone.Brand = "Nokia";
secondPhone.Brand = "N12";
secondPhone.Size = "120x100x12";
secondPhone.Call("32423234");
secondPhone.SendSMS("232342134", "Hi, there!");
Console.WriteLine("-------------------------------------");

//----------  2nd task  ----------

Car fastCar = new Car();
fastCar.Brand = "Mercedes";
fastCar.Color = "red";
fastCar.NumberPlate = "AF1212";
fastCar.Drive();
fastCar.DriveFaster();
fastCar.DriveFaster();
fastCar.Brake();
fastCar.SoundTheHorn();
Console.WriteLine("-------------------------------------");

//----------  3rd task  ----------
Product bestProduct = new Product(88.2, 13, 200.34, 200.2);
bestProduct.Name = "Box";
Console.WriteLine(bestProduct.PrintProductDescription());
Console.WriteLine("-------------------------------------");
//----------  4th task  ----------

Person firstPerson = new Person();
Console.WriteLine("Please enter your name: ");
firstPerson.Name = Console.ReadLine();
Console.WriteLine("Please enter your surname: ");
firstPerson.Surname = Console.ReadLine();
Console.WriteLine("When were you born? ");
firstPerson.BirthDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("What is your hobby? ");
firstPerson.Hobby = Console.ReadLine();
firstPerson.PrintHello();