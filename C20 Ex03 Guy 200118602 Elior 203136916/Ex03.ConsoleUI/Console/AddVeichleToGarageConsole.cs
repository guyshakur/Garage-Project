using System;
using Ex03.GarageLogic;
using Ex03.GarageLogic.Enums;
using Ex03.GarageLogic.Garage;

namespace Ex03.ConsoleUI
{
	public class AddVeichleToGarageConsole
	{
		private static string s_FullNameCustomer;
		private static string s_PhoneNumberCustomer;
		public static string FullNameCustomer
		{
			get
			{
				return s_FullNameCustomer;
			}
			set
			{
				s_FullNameCustomer = value;
			}
		}
		public static string PhoneNumberCustomer
		{
			get
			{
				return s_PhoneNumberCustomer;
			}
			set
			{
				s_PhoneNumberCustomer = value;
			}
		}
		public static eTypeOfVeichle AddVeichleToGarage()
		{
			//bool correct = false;
			string readTypeOfVeicle;
			Console.WriteLine("Please enter your full name");
			FullNameCustomer = Console.ReadLine();
			Console.WriteLine("Please enter your phone number");
			PhoneNumberCustomer = Console.ReadLine();
			//do
			//{
			readTypeOfVeicle = addVeichleChoice();
			//GarageConsole.checkIfQ(readTypeOfVeicle);
			//if (GarageConsole.checkReadFromUser(readTypeOfVeicle, 5))
			//{
			//correct = true;
			switch (int.Parse(readTypeOfVeicle))
			{
				case 1:
					{
						fuelCar();
						break;
					}
				case 2:
					{
						electricCar();
						break;
					}
				case 3:
					{
						fuelMotorCycle();
						break;
					}
				case 4:
					{
						ElectricMotorCycle();
						break;
					}
				case 5:
					{
						truck();
						break;
					}
			}
			//}
			//} while (!correct);

			return (eTypeOfVeichle)int.Parse(readTypeOfVeicle);
		}

		private static void fuelCar()
		{
			Console.WriteLine("Please enter licence id of the car:");
			string licenceID = Console.ReadLine();
			Console.WriteLine("Please enter Model of the car");
			string model = Console.ReadLine();
			Console.WriteLine("Please enter current gas amount of the car (numeric)");
			float currentGazAmount = float.Parse(Console.ReadLine());
			Console.WriteLine("please enter Tires Model of the car");
			string tiresModel = Console.ReadLine();
			Console.WriteLine("Please enter Tires Current pressure of the car (numeric)");
			//float tiresCurrentPressure = float.Parse(Console.ReadLine());
			float tiresCurrentPressure = float.Parse(Console.ReadLine());
			Console.WriteLine("Please enter Color of the car\ngrey->1, green->2, white->3 , red->4");
			eColors color = (eColors)int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter doors type of the car");
			eDoorsType doorsType = (eDoorsType)(int.Parse(Console.ReadLine()) - 1);
			//Car c = new Car();
			Garage g = new Garage();
			g.AddCustomer(FullNameCustomer, PhoneNumberCustomer, licenceID);

			try
            {
				g.AddCarAndFillWithDetails(eTypeOfVeichle.FuelCar, licenceID, model
				, currentGazAmount, tiresModel, tiresCurrentPressure, color,
				doorsType);
			}
			catch(ValueOutOfRangeException ex)
            {
				Console.WriteLine(ex.Message);
            }

		}
		private static void electricCar()
		{
			Console.WriteLine("Please enter licence id of the car:");
			string licenceID = Console.ReadLine();
			Console.WriteLine("Please enter Model of the car");
			string model = Console.ReadLine();
			Console.WriteLine("Please enter current hours lefft for battery of the car (numeric)");
			float currentHoursLeftForBattery = float.Parse(Console.ReadLine());
			Console.WriteLine("please enter Tires Model of the car");
			string tiresModel = Console.ReadLine();
			Console.WriteLine("Please enter Tires Current pressure of the car (numeric)");
			float tiresCurrentPressure = float.Parse(Console.ReadLine());
			Console.WriteLine("Please enter Color of the car\ngrey->1, green->2, white->3 , red->4");
			eColors color = (eColors)int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter doors type of the car");
			eDoorsType doorsType = (eDoorsType)(int.Parse(Console.ReadLine()) - 1);
			//Car c = new Car();
			Garage g = new Garage();
			g.AddCustomer(FullNameCustomer, PhoneNumberCustomer, licenceID);
			g.AddCarAndFillWithDetails(eTypeOfVeichle.ElectricCar, licenceID, model,
				currentHoursLeftForBattery, tiresModel, tiresCurrentPressure, color,
				doorsType);
		}
		private static void fuelMotorCycle()
		{
			Console.WriteLine("Please enter licence id of the car:");
			string licenceID = Console.ReadLine();
			Console.WriteLine("Please enter Model of the car");
			string model = Console.ReadLine();
			Console.WriteLine("Please enter current gas amount of the car (numeric)");
			float currentGazAmount = float.Parse(Console.ReadLine());
			Console.WriteLine("please enter Tires Model of the car");
			string tiresModel = Console.ReadLine();
			Console.WriteLine("Please enter Tires Current pressure of the car (numeric)");
			float tiresCurrentPressure = float.Parse(Console.ReadLine());
			Console.WriteLine("Please enter licence type of the car\nA->1, A1->2, B1->3 , B2->4");
			eLiecenceType licenceType = (eLiecenceType)int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter engine capacity of the car(cc)");
			float engineCapacity = float.Parse(Console.ReadLine());
			//Car c = new Car();
			Garage garage = new Garage();
			garage.AddCustomer(FullNameCustomer, PhoneNumberCustomer, licenceID);
			garage.AddMotorAndFillWithDetails(eTypeOfVeichle.FuelMotorCycle, licenceID,
				model, currentGazAmount, tiresModel, tiresCurrentPressure, licenceType, engineCapacity);
		}
		private static void ElectricMotorCycle()
		{
			Console.WriteLine("Please enter licence id of the car:");
			string licenceID = Console.ReadLine();
			Console.WriteLine("Please enter Model of the car");
			string model = Console.ReadLine();
			Console.WriteLine("Please enter current hours lefft for battery of the car (numeric)");
			float currentHoursLeftForBattery = float.Parse(Console.ReadLine());
			Console.WriteLine("please enter Tires Model of the car");
			string tiresModel = Console.ReadLine();
			Console.WriteLine("Please enter Tires Current pressure of the car (numeric)");
			float tiresCurrentPressure = float.Parse(Console.ReadLine());
			Console.WriteLine("Please enter licence type of the car\nA->1, A1->2, B1->3 , B2->4");
			eLiecenceType licenceType = (eLiecenceType)int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter engine capacity of the car(cc)");
			float engineCapacity = float.Parse(Console.ReadLine());
			//Car c = new Car();
			Garage garage = new Garage();
			garage.AddCustomer(FullNameCustomer, PhoneNumberCustomer, licenceID);
			garage.AddMotorAndFillWithDetails(eTypeOfVeichle.ElectricMotorCycle, licenceID,
				model, currentHoursLeftForBattery, tiresModel, tiresCurrentPressure, licenceType, engineCapacity);
		}
		private static void truck()
		{
			Console.WriteLine("Please enter licence id of the car:");
			string licenceID = Console.ReadLine();
			Console.WriteLine("Please enter Model of the car");
			string model = Console.ReadLine();
			Console.WriteLine("Please enter current gas amount of the car (numeric)");
			float currentGazAmount = float.Parse(Console.ReadLine());
			Console.WriteLine("please enter Tires Model of the car");
			string tiresModel = Console.ReadLine();
			Console.WriteLine("Please enter Tires Current pressure of the car (numeric)");
			float tiresCurrentPressure = float.Parse(Console.ReadLine());
			Console.WriteLine("Please enter Does contains danger matirials(Y/N)");
			String read = Console.ReadLine();
			bool isDanger = read == "Y" || read == "y";
			Console.WriteLine("Please enter engine capacity of the car(cc)");
			float engineCapacity = float.Parse(Console.ReadLine());
			//Car c = new Car();
			Garage garage = new Garage();
			garage.AddCustomer(FullNameCustomer, PhoneNumberCustomer, licenceID);
			garage.AddTruckAndFillWithDetails(eTypeOfVeichle.Truck, licenceID,
				model, currentGazAmount, tiresModel, tiresCurrentPressure, isDanger, engineCapacity);
		}
		private static string addVeichleChoice()
		{
			Console.Clear();
			Console.WriteLine("     Add Veichle To Garage");
			Console.WriteLine("in any location if you press on key 'Q' you return to main menu");
			Console.WriteLine("please choose:\n" +
				"1. Fuel Car\n" +
				"2. Electric Car\n" +
				"3. Fuel MotorCycle\n" +
				"4. Electric MotorCycle\n" +
				"5. Truck\n");
			string readFromUser;
			do
			{
				readFromUser = Console.ReadLine();
				GarageConsole.checkIfQ(readFromUser);
			} while (!GarageConsole.checkReadFromUser(readFromUser, 5));
			return readFromUser;

		}
	}
}
