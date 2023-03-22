using System;
using System.Collections;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using VS_21_February.Task10;
using VS_21_February.Task10.Task10.carandengine;
using VS_21_February.Task10.point;
class Hello
{
	static void Main(string[] args)
	{
		////Home task 1 lesson 10
		//GenericClass<string> array = new GenericClass<string>();
		//array.AddItemToArray("Add");
		//array.AddItemToArray("Remove");
		//array.AddItemToArray("New");
		//array.AddItemToArray("item");
		//array.AddItemToArray("Test");
		//array.AddItemToArray("22 March");
		//array.AddItemToArray("Remove new");

		//Console.WriteLine(array.ArrayLength());

		//array.RemoveItemFromArray("New");

		//Console.WriteLine(array.ArrayLength());

		//array.GetItemByIndex(2);
		//array.GetItemByIndex(4);
		//array.GetItemByIndex(9);

		//Home task 3 lesson 10
		Point<int> pointInt = new Point<int>(10, 20);

		pointInt.GetInfo();

		////Home task 0.1 lesson 9
		//ArrayList list = new ArrayList();
		//list.AddRange(new string[] { "Different types", "Test", "New" });
		//list.Add(5.5);
		//list.Add(25);
		//list.Add(19);

		//try
		//{
		//	object s = list[18];
		//}
		//catch (ArgumentOutOfRangeException ex)
		//{
		//	Console.WriteLine($"Catch the exception:\n{ex.Message}");
		//}
		//catch (Exception ex)
		//{
		//	Console.WriteLine($"\n{ex.Message}");
		//}

		////Home task 0.2 lesson 9
		//var dogBreed = new Dictionary<int, string>()
		//{
		//	[1] = "Labrador Retriever",
		//	[2] = "Akita",
		//	[3] = "Weimaraner",
		//	[4] = "Border Collie",
		//	[5] = "Bulldog",
		//	[6] = "King Charles Spaniel",
		//	[7] = "Chow Chow",
		//	[8] = "Dalmatian",
		//	[9] = "Doberman",
		//	[10] = "Pug Dog"
		//};

		//foreach (var dog in dogBreed)
		//{
		//	Console.WriteLine($"Number: {dog.Key}, Dog Breed: {dog.Value}");
		//}

		////HomeTask 1 lesson 9
		//List<Product> products = new List<Product>()
		//{
		//	new ProductsInShop("Cake Napoleon", 45.5, DateTime.Parse("03.10.2023 14:40"), 9),
		//	new ProductsInShop("Oat milk", 8, DateTime.Parse("03.05.2023"), 30),
		//	new ProductsInShop("Pomelo", 9, DateTime.Parse("02.25.2023"), 28),
		//	new ProductsInShop("Sausage", 10, DateTime.Parse("03.08.2023"), 14),
		//	new ProductsInShop("Buckwheat", 8, DateTime.Parse("12.21.2022"), 180),
		//	new ProductsInShop("Сrab sticks", 9, DateTime.Parse("06.09.2022"), 220),
		//	new Batch("Greenfield tea", 7.5, 25, DateTime.Parse("08.25.2022"), 360),
		//	new Batch("Сoffee Dallmayr", 16, 40, DateTime.Parse("12.21.2022"), 360),
		//	new Batch("Cookies BelVita", 6, 50, DateTime.Parse("01.01.2023"), 180),
		//	new Batch("Cheese Parmezan", 25, 100, DateTime.Parse("03.06.2023"), 120),
		//	new Batch("Cream", 12, 20, DateTime.Parse("02.18.2023"), 14),
		//};

		//DateTime now = DateTime.Now;

		////Display full information from the database on the screen
		//foreach (var product in products)
		//{
		//	Console.WriteLine($"\n{product.GetInfo()}\nCheck expiration date: {product.CheckExpirationDate(now)}");
		//}

		//////Search for expired goods (at the time of the current date)

		//Console.WriteLine("\nThe expiration date products:");

		//foreach (var product in products)
		//{
		//	if (product.CheckExpirationDate(now).Contains("Expired!"))
		//	{
		//		Console.WriteLine("\n" + product.GetInfo() + product.CheckExpirationDate(now));
		//	}
		//}

		////HomeTask 1.1 lesson 9
		//List<Product> products_1 = new List<Product>()
		//{
		//	new ProductsInShop("Almond croissant", 10, DateTime.Parse("03.18.2023 08:40"), 2),
		//	new ProductsInShop("Smoked salmon", 21, DateTime.Parse("03.16.2023"), 30),
		//	new ProductsInShop("Black bread", 5.5, DateTime.Parse("03.18.2023"), 5),
		//	new ProductsInShop("Red caviar", 45, DateTime.Parse("03.01.2023"), 90),
		//	new ProductsInShop("Сottage cheese", 7, DateTime.Parse("03.07.2023"), 60),
		//};

		//foreach (var product in products_1)
		//{
		//	Console.WriteLine(product.GetInfo());
		//}

		////Change the price of one product by 100.
		//products_1[3] = new ProductsInShop("Red caviar", 100, DateTime.Parse("03.01.2023"), 90);

		////Delete the last product.
		//products_1.RemoveAt(products_1.Count - 1);

		//Console.WriteLine("\nAfter deletion the last product:");

		//foreach (var product in products_1)
		//{
		//	Console.WriteLine(product.GetInfo());
		//}

		////Remove all products.
		//products_1.Clear();

		////HomeTask 1.2 lesson 9
		//List<Product> products_2 = new List<Product>()
		//{
		//	new ProductsInShop("Shrimps frozen", 150, DateTime.Parse("03.18.2023 08:40"), 150),
		//	new ProductsInShop("Salmon steak frozen", 310, DateTime.Parse("03.16.2023"), 150),
		//	new ProductsInShop("Black caviar", 550, DateTime.Parse("03.18.2023"), 110),
		//	new ProductsInShop("Red caviar", 300.5, DateTime.Parse("03.01.2023"), 90),
		//	new ProductsInShop("Goat cheese", 420, DateTime.Parse("03.07.2023"), 60),
		//	new ProductsInShop("Shark frozen", 650, DateTime.Parse("03.01.2023"), 120),
		//	new ProductsInShop("Hazelnut cake", 120, DateTime.Parse("03.16.2023"), 6),
		//	new ProductsInShop("Langoustines frozen", 480, DateTime.Parse("03.18.2023"), 150),
		//};

		//List<Product> productsHighPrice = new();


		//foreach (var product in products_2.ToList())
		//{
		//	product.MoveElementToNewCollection(products_2, productsHighPrice);
		//}

		//Console.WriteLine("\nProducts with price < 300\n");

		//foreach (var product in products_2.ToList())
		//{
		//	Console.WriteLine(product.GetInfo());
		//}

		//Console.WriteLine("\nNew collection products with price > 300:\n");

		//productsHighPrice.Sort();

		//foreach (var product in productsHighPrice)
		//{
		//	Console.WriteLine(product.GetInfo());
		//}

		//Console.WriteLine($"\nMinimum price: {productsHighPrice.Min()}");

		////HomeTask 1.3 lesson 9
		//var productAvailable = new Dictionary<Product, int>()
		//{
		//	[new ProductsInShop("Almond croissant")] = 20,
		//	[new ProductsInShop("Smoked salmon")] = 30,
		//	[new ProductsInShop("Black bread")] = 18,
		//	[new ProductsInShop("Red caviar")] = 10,
		//	[new ProductsInShop("Сottage cheese")] = 7,
		//	[new ProductsInShop("Cake Napoleon")] = 3,
		//	[new ProductsInShop("Sausage")] = 6,
		//};

		//foreach (KeyValuePair<Product, int> product in productAvailable)
		//{
		//	Console.WriteLine($"{product.Key}, Count = {product.Value}");
		//}

		//foreach (KeyValuePair<Product, int> product in productAvailable)
		//{
		//	Console.WriteLine($"{product.Key}");
		//}

		//foreach (KeyValuePair<Product, int> product in productAvailable)
		//{
		//	Console.WriteLine($"Price:{product.Value}");
		//}

		////write a Dictionary to List conversion.
		////https://www.techiedelight.com/ru/convert-dictionary-to-a-list-in-csharp/
		//List<KeyValuePair<Product, int>> coversionDictionaryToList = productAvailable.ToList();

		//Console.WriteLine(String.Join(",\n", coversionDictionaryToList));

		////Write a List to Dictionary conversion.
		////https://learn.microsoft.com/ru-ru/dotnet/api/system.linq.enumerable.todictionary?view=net-7.0
		//List<Product> products_3 = new List<Product>()
		//{
		//	new ProductsInShop("Shrimps frozen", 40.5),
		//	new ProductsInShop("Salmon steak frozen", 70),
		//	new ProductsInShop("Black caviar", 150),
		//	new ProductsInShop("Almond croissant", 9),
		//	new ProductsInShop("Cake Napoleon", 45.5),
		//	new ProductsInShop("Cheezecake", 34),
		//};

		//products_3.Sort();

		//Dictionary<double, Product> coversionListToDictionary = products_3.ToDictionary(x => x.Price);

		//foreach (KeyValuePair<double, Product> product in coversionListToDictionary)
		//{
		//	Console.WriteLine($"Price: {product.Key}, {product.Value}");
		//}

		//HomeTask 1 lesson 8
		//var form_Correct = AuthorizationForm.CheckException("Anastasiya", "test1", "test1");
		//var loginIncorrect = AuthorizationForm.CheckException("Kate ", "newss1", "newss1");
		//var passwordIncorrect = AuthorizationForm.CheckException("Violeta", "testpassword", "testpassword");
		//var confirmationPassworddIncorrect = AuthorizationForm.CheckException("Maksim", "check0425ddd!newd", "check0425dd!newdd");

		//Console.WriteLine(form_Correct);
		//Console.WriteLine(loginIncorrect);
		//Console.WriteLine(passwordIncorrect);
		//Console.WriteLine(confirmationPassworddIncorrect);

		//HomeTask 1 lesson 7
		//Public autopark
		//Bus bus_1 = new Bus("Minsk - Gomel", "2290-NB-3", "14:30", 30);
		//Trolleybus trolleybus_1 = new Trolleybus("DS Kyntsevshina - DS Malinovka", "9917-VS-5", "12:25", 83);
		//Tramcar tramcar_1 = new Tramcar("DS Zeleny Lyg - Myasnikova", "7760-AZ-6", "08:17", 100);
		//Bus bus_2 = new Bus("Minsk - Berlin", "7777-NN-7", "06:20", 28);
		//Trolleybus trolleybus_2 = new Trolleybus("DS Kyntsevshina - DS Malinovka", "7717-VS-6", "14:15", 70);

		////Interface IGetInfo
		//bus_1.GetInfo();
		//trolleybus_1.GetInfo();
		//tramcar_1.GetInfo();

		////Define in the superclass (class PublicTransport) a method that returns the type of transport (Electric, Rail, etc.).
		////Override this method in derived classes.
		//Console.WriteLine(bus_1.ReturnType());
		//Console.WriteLine(trolleybus_1.ReturnType());
		//Console.WriteLine(tramcar_1.ReturnType());

		////Sort the transport by the number of seats and output the data of the objects to the console.
		////I use: https://www.techiedelight.com/ru/sort-an-array-of-objects-by-a-specific-field-in-csharp/
		//var arrayPublicTransport = new PublicTransport[] { bus_1, bus_2, trolleybus_1, tramcar_1, trolleybus_2 };

		//var sorted = arrayPublicTransport.OrderBy(ob => ob.NumberOfSeats).ToArray();

		//Array.ForEach(sorted, Console.WriteLine);

		////Ask the user for a departure time and/or destination.
		////Find an object in the array that matches the given parameters and output its data to the console.
		//Console.WriteLine("Please enter the departure time");

		//string? timeFromUser = Console.ReadLine();

		//Console.WriteLine("Please enter the Destination");

		//string? destinationFromUser = Console.ReadLine();

		//foreach (var transport in arrayPublicTransport)
		//{
		//    if(transport.DepartureTime == timeFromUser || transport.Destination == destinationFromUser)
		//    {
		//        Console.WriteLine(string.Format("{0}, {1}, {2}", transport.Number, transport.Destination, transport.DepartureTime));
		//    }
		//}

		////Ask the user for a departure time.
		////Print to the console a list of vehicles leaving after the specified time.
		//Console.WriteLine("Please enter the departure time");

		//string? timeFromUser_2 = Console.ReadLine();
		//DateTime dateTime = DateTime.Parse(timeFromUser_2);

		//foreach (var transport in arrayPublicTransport)
		//{
		//    if (DateTime.Parse(transport.DepartureTime) > dateTime)
		//    {
		//        Console.WriteLine(string.Format("{0}, {1}, {2}", transport.DepartureTime, transport.Number, transport.Destination));
		//    }
		//}

		////Sealed method NumberOfTrips
		//PublicTransport transport_1 = new Tramcar("DS Zeleny Lyg - Myasnikova", "7760-AZ-6", "08:17", 100);
		//transport_1.NumberOfTrips();
		//bus_1.NumberOfTrips();

		////Create a TransportService class.
		////Define a printTransportType method inside the TransportService class that will accept an object of type Transport as a parameter.
		////Inside the printTransportType method, you need to call another method that returns the transport type and print this information to the console.
		//Console.WriteLine(new TransportService().PrintTransportType(tramcar_1));
		//Console.WriteLine(new TransportService().PrintTransportType(trolleybus_1));
		//Console.WriteLine(new TransportService().PrintTransportType(bus_1));

		//////HomeTask 1 lesson 6
		//Triangles triangle_1 = new TriangleBuilder().CreateTriangle(5, 5, 8);
		//Triangles triangle_2 = new TriangleBuilder().CreateTriangle(6, 6, 6);
		//Triangles triangle_3 = new TriangleBuilder().CreateTriangle(3, 4, 5);
		//Triangles triangle_4 = new TriangleBuilder().CreateTriangle(9, 13, 14);

		//Console.Write(triangle_1.GetSquare());
		//Console.Write(triangle_2.GetSquare());
		//Console.Write(triangle_3.GetSquare());
		//Console.Write(triangle_4.GetSquare());

		//Rectangle rectangle_1 = new RectangleBuilder().CreateRectangle(9, 10);
		//Rectangle rectangle_2 = new RectangleBuilder().CreateRectangle(15, 15);

		//Console.Write(rectangle_1.GetSquare());
		//Console.Write(rectangle_2.GetSquare());

		//var arrayFigures = new Figure[] { triangle_1, triangle_2, triangle_3, triangle_4, rectangle_1, rectangle_2 };

		//foreach (var figure in arrayFigures)
		//{
		//    if (figure != null)
		//    {
		//        Console.Write(figure.GetSquare().ToString("#.###"));
		//    }
		//}

		////HomeTask 2 lesson 6
		//Doctor doctor_1 = new Doctor("Alexander Derytev", 10, 1);
		//Doctor doctor_2 = new Doctor("Alesya Nogertty", 4, 2);
		//Doctor doctor_3 = new Doctor("Kirill Vasendor", 8, 1);

		//Patient patient_1 = new Patient("Viacheslav Parsen", 25);
		//Patient patient_2 = new Patient("Kelly Brandy", 54);
		//Patient patient_3 = new Patient("Andrey Villy", 18);

		//TreatmentPlan treatmentPlan_1 = new TreatmentPlan(patient_1, 1, doctor_1);
		//TreatmentPlan treatmentPlan_2 = new TreatmentPlan(patient_2, 1, doctor_2);
		//TreatmentPlan treatmentPlan_3 = new TreatmentPlan(patient_3, 1, doctor_3);

		//Console.WriteLine(treatmentPlan_1.SelectDoctor(patient_1, 1, doctor_1).Treat());
		//Console.WriteLine(treatmentPlan_1.SelectDoctor(patient_2, 2, doctor_2).Treat());
		//Console.WriteLine(treatmentPlan_1.SelectDoctor(patient_3, 3, doctor_3).Treat());

		////Home task lesson 5
		////First Home Task
		//VS_21_February.Phone iphone_13 = new VS_21_February.Phone();

		//iphone_13.number = "13";
		//iphone_13.model = "Iphone";
		//iphone_13.weight = 0.173;

		//VS_21_February.Phone samsung_Galaxy = new VS_21_February.Phone();

		//samsung_Galaxy.number = "S 23";
		//samsung_Galaxy.model = "Samsung Galaxy S Ultra";
		//samsung_Galaxy.weight = 0.234;

		//VS_21_February.Phone huawei = new VS_21_February.Phone();

		//huawei.number = "P50";
		//huawei.model = "Huawei Pro";
		//huawei.weight = 0.195;

		//Console.WriteLine($"Phone 1: number {iphone_13.number}, model {iphone_13.model}, weight {iphone_13.weight}");
		//Console.WriteLine($"Phone 2: number {samsung_Galaxy.number}, model {samsung_Galaxy.model}, weight {samsung_Galaxy.weight}");
		//Console.WriteLine($"Phone 3: number {huawei.number}, model {huawei.model}, weight {huawei.weight}");

		////Method ReceiveCall
		//iphone_13.ReceiveCall("Masha");

		//samsung_Galaxy.ReceiveCall("Michael");

		//huawei.ReceiveCall("Elizaveta");

		////Method GetNumber
		//iphone_13.phoneNumber = 80441371010;
		//iphone_13.GetNumber();

		//Console.WriteLine(iphone_13.phoneNumber);

		//samsung_Galaxy.phoneNumber = 80293386767;
		//samsung_Galaxy.GetNumber();

		//Console.WriteLine(samsung_Galaxy.phoneNumber);

		//huawei.phoneNumber = 80449480999;
		//huawei.GetNumber();

		//Console.WriteLine(huawei.phoneNumber);

		////Constructor with 2 parametres
		//VS_21_February.Phone lenovo = new("K14", "Lenovo");

		//Console.WriteLine($"Phone 4: number {lenovo.number}, model {lenovo.model}, weight {lenovo.weight}");

		////overloaded method ReceiveCall
		//iphone_13.ReceiveCall("Nastya", 80447222525);

		////Method SendMessage
		//samsung_Galaxy.SendMessage(80293334567, 80447568990, 80445682130, 80297775507);

		//huawei.SendMessage();

		////Second Home Task
		//VS_21_February.CreditCard card_1 = new VS_21_February.CreditCard();

		//card_1.accountNumber = "BY11ALFA100110DA7U9910101000";
		//card_1.currentSumm = 51000.5;

		//VS_21_February.CreditCard card_2 = new VS_21_February.CreditCard();

		//card_2.accountNumber = "BY24ALFA200160PP7U0670101001";
		//card_2.currentSumm = 145000.9;

		//VS_21_February.CreditCard card_3 = new VS_21_February.CreditCard();

		//card_3.accountNumber = "BY97ALFA110960SE7K0990401003";
		//card_3.currentSumm = 28000.3;

		//card_1.AccrualMoney(8000.5);

		//card_2.AccrualMoney(14700);

		//card_3.WithdrawalMoney(30000);

		//card_1.CurrentStatus();

		//card_2.CurrentStatus();

		//card_3.CurrentStatus();

		////Third Home Task partially performed
		//VS_21_February.CashMachine atm_1 = new(1, 1, 1);

		//atm_1.DepositingMoney(1, 1, 1);

		//atm_1.WithdrawalMoney(350);
	}

	public static void Lesson1_Task1()
	{
		char name = char.Parse(Console.ReadLine());
		Console.WriteLine("Hello, World!");
		Console.WriteLine("Hello, " + name);
	}

	public static void Lesson2_Task1()
	{
		int operand1 = 25;
		int operand2 = 5;
		string sign = Console.ReadLine();
		int result;

		switch (sign)
		{
			case "+":
				result = operand1 + operand2;
				Console.WriteLine($"addition operation: {operand1} {sign} {operand2} = {result}");
				break;
			case "-":
				result = operand1 - operand2;
				Console.WriteLine($"subtraction operation: {operand1} {sign} {operand2} = {result}");
				break;
			case "*":
				result = operand1 * operand2;
				Console.WriteLine($"multiplication operation: {operand1} {sign} {operand2} = {result}");
				break;
			case "/":
				if ((operand2 != 0))
				{
					result = operand1 / operand2;
					Console.WriteLine($"division operation: {operand1} {sign} {operand2} = {result}");
				}
				else
				{
					Console.WriteLine($"Error! Dividing by Zero impossible");
				}
				break;
			default:
				Console.WriteLine($"The calculator can only perform operations of addition, subtraction, division, multiplication.\nPlease enter a sign only for available operations.");
				break;
		}
	}

	public static void Lesson2_Task2()
	{
		int number = int.Parse(Console.ReadLine());

		if ((number >= 0) && (number <= 14))
		{
			Console.WriteLine($"The entered number is between 0 and 14");
		}
		else if ((number >= 15) && (number <= 35))
		{
			Console.WriteLine($"The entered number is between 15 and 35");
		}
		else if ((number >= 36) && (number <= 50))
		{
			Console.WriteLine($"The entered number is between 36 and 50");
		}
		else if ((number >= 51) && (number <= 100))
		{
			Console.WriteLine($"The entered number is between 51 and 100");
		}
		else
		{
			Console.WriteLine($"The entered number is not included in any of the existing ranges. Please enter integer number from 0 to 100");
		}
	}

	public static void Lesson2_Task3()
	{
		string badWeather_1 = "cold";
		string badWeather_2 = "freezing";
		string badWeather_3 = "humid";
		string badWeather_4 = "rainy";
		string badWeather_5 = "unsettled";
		string goodWeather_1 = "sunny";
		string goodWeather_2 = "cloudless";
		string goodWeather_3 = "warm";
		string goodWeather_4 = "chilly";
		string goodWeather_5 = "thaw";
		string weather = Console.ReadLine();

		if ((weather == "холодно") || (weather == "холодная"))
		{
			Console.WriteLine($"Translate to English: {badWeather_1}");
		}
		else if ((weather == "очень холодно") || (weather == "очень холодная"))
		{
			Console.WriteLine($"Translate to English: {badWeather_2}");
		}
		else if ((weather == "влажно") || (weather == "влажная"))
		{
			Console.WriteLine($"Translate to English: {badWeather_3}");
		}
		else if ((weather == "дождливо") || (weather == "дождливая"))
		{
			Console.WriteLine($"Translate to English: {badWeather_4}");
		}
		else if ((weather == "неустойчивая") || (weather == "переменчивая"))
		{
			Console.WriteLine($"Translate to English: {badWeather_5}");
		}
		else if ((weather == "солнечно") || (weather == "солнечная"))
		{
			Console.WriteLine($"Translate to English: {goodWeather_1}");
		}
		else if ((weather == "безоблачно") || (weather == "безоблачная"))
		{
			Console.WriteLine($"Translate to English: {goodWeather_2}");
		}
		else if ((weather == "тепло") || (weather == "теплая"))
		{
			Console.WriteLine($"Translate to English: {goodWeather_3}");
		}
		else if ((weather == "прохладно") || (weather == "прохладная"))
		{
			Console.WriteLine($"Translate to English: {goodWeather_4}");
		}
		else if ((weather == "оттепель") || (weather == "потепление"))
		{
			Console.WriteLine($"Translate to English: {goodWeather_5}");
		}
		else
		{
			Console.WriteLine($"There is no translation for this word");
		}
	}

	public static void Lesson2_Task4_Way1()
	{
		int number = int.Parse(Console.ReadLine());

		if (number % 2 == 0)
		{
			Console.WriteLine($"The entered number is even");
		}
		else
		{
			Console.WriteLine($"The entered number is odd");
		}
	}

	public static void Lesson2_Task4_Way2()
	{
		int number = int.Parse(Console.ReadLine());

		switch (number % 2)
		{
			case 0:
				Console.WriteLine($"The entered number is even");
				break;
			default:
				Console.WriteLine($"The entered number is odd");
				break;
		}
	}
}
