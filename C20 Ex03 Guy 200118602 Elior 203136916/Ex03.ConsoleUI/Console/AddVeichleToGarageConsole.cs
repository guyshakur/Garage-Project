using System;
using System.Security.AccessControl;
using Ex03.GarageLogic;
using Ex03.GarageLogic.Enums;
using Ex03.GarageLogic.Garage;

namespace Ex03.ConsoleUI
{
	public class AddVeichleToGarageConsole
	{
		public static eTypeOfVeichle AddVeichleToGarage()
		{
			
			string phoneNumber, fullName;
			string licenceID, model, tiresModel;
			float currentGazAmountOrHoursLeftForBattery, tiresCurrentPressure, capacity=0;
			int intColor, intDoorsType, readTypeOfVeicle, intLicenceType;
			bool conrainsIsDanger = false;
			eColors color = eColors.Gray;
			eDoorsType doorType = eDoorsType.Two;
			eLiecenceType liecenceType = eLiecenceType.A;
			Garage garage = new Garage();
			Console.Clear();
			readTypeOfVeicle = int.Parse(addVeichleChoice());
			Console.WriteLine("Please enter licence id of the car:");
			licenceID = Console.ReadLine();
			if (!Garage.IsLicenceIDExistInGarage(licenceID))
			{
				Console.WriteLine("Please enter your full name");
				fullName = Console.ReadLine();
				Console.WriteLine("Please enter your phone number");
				phoneNumber = Console.ReadLine();
				Console.WriteLine("Please enter Model of the car");
				model = Console.ReadLine();
				do
				{
					if ((eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelCar ||           //1
						(eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelMotorCycle ||    //3
						(eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.Truck)               //5
					{
						Console.WriteLine("Please enter current gas amount of the car (numeric)");
					}
					else                                                                        //2,4
					{
						Console.WriteLine("Please enter current hours lefft for battery of the car (numeric)");
					}
				} while (!float.TryParse(Console.ReadLine(), out currentGazAmountOrHoursLeftForBattery));
				Console.WriteLine("please enter Tires Model of the car");
				tiresModel = Console.ReadLine();
				do
				{
					Console.WriteLine("Please enter Tires Current pressure of the car (numeric)");
				} while (!float.TryParse(Console.ReadLine(), out tiresCurrentPressure));
				if ((eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelCar ||           //1
					(eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.ElectricCar)         //2
				{
					do
					{
						Console.WriteLine("Please enter Color of the car\ngrey->1, green->2, white->3 , red->4");
					} while (!(int.TryParse(Console.ReadLine(), out intColor) && intColor >= 1 && intColor <= 4));
					color = (eColors)intColor;
				}
				else if ((eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelMotorCycle ||   //3
					(eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.ElectricMotorCycle)      //4
				{
					do
					{
						Console.WriteLine("Please enter licence type of the car\nA->1, A1->2, B1->3 , B2->4");
					} while (!(int.TryParse(Console.ReadLine(), out intLicenceType) && intLicenceType >= 1 && intLicenceType <= 4));
					liecenceType = (eLiecenceType)intLicenceType;
				}
				else                                                                            //5
				{
					string read;
					do
					{
						Console.WriteLine("Please enter Does contains danger matirials(Y/N)");
						read = Console.ReadLine();
					} while (!(read == "y" || read == "Y" || read == "n" || read == "N"));
					conrainsIsDanger = read == "Y" || read == "y";
				}
				if ((eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelCar ||           //1
					(eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.ElectricCar)         //2
				{
					do
					{
						Console.WriteLine("Please enter doors type of the car(between 2-5)");
					} while (!((int.TryParse(Console.ReadLine(), out intDoorsType)) && intDoorsType >= 2 && intDoorsType <= 5));
					doorType = (eDoorsType)(intDoorsType - 1);
				}
				else                                                                        //3,4,5
				{
					do
					{
						Console.WriteLine("Please enter engine capacity of the car(cc)");

					} while (!(float.TryParse(Console.ReadLine(), out capacity)));
				}
				try
				{
					if ((eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelCar ||           //1
						(eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.ElectricCar)         //2
					{
						garage.AddCarAndFillWithDetails((eTypeOfVeichle)readTypeOfVeicle, licenceID,
							model, currentGazAmountOrHoursLeftForBattery, tiresModel, tiresCurrentPressure,
							color, doorType);
						Console.WriteLine("added a new car is succeess");
						Console.WriteLine("for exit to main menu press any key");
						Console.ReadLine();
					}
					else if ((eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelMotorCycle ||   //3
					(eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.ElectricMotorCycle)			//4
					{
						garage.AddMotorAndFillWithDetails((eTypeOfVeichle)readTypeOfVeicle,
							licenceID, model, currentGazAmountOrHoursLeftForBattery,
							tiresModel, tiresCurrentPressure, liecenceType, capacity);
						Console.WriteLine("added a new motorecycle is succeess");
						Console.WriteLine("for exit to main menu press any key");
						Console.ReadLine();
					}
					else                                                                            //5
					{
						garage.AddTruckAndFillWithDetails(eTypeOfVeichle.Truck, licenceID,
							model, currentGazAmountOrHoursLeftForBattery, tiresModel,
							tiresCurrentPressure, conrainsIsDanger,	capacity);
						Console.WriteLine("added a new truck is succeess");
					}
					garage.AddCustomer(fullName, phoneNumber, licenceID);
					Console.WriteLine("for exit to main menu press any key");
					Console.ReadLine();
				}
				catch(ValueOutOfRangeException ex)
				{
					Console.WriteLine();
					Console.WriteLine();
					Console.WriteLine(ex.Message);
					Console.WriteLine("added a new car/motorcycle/truck is failed.\nto try again press any key");
					Console.ReadLine();
					//System.Threading.Thread.Sleep(1500);
					return AddVeichleToGarage();
				}

			}
			else
			{
				Console.WriteLine("The Licence ID is exists");
				Console.WriteLine("for exit to main menu press any key");
				Console.ReadLine();
			}
			System.Threading.Thread.Sleep(1500);
			return (eTypeOfVeichle)readTypeOfVeicle;
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
//GarageConsole.checkIfQ(readTypeOfVeicle);
//if (GarageConsole.checkReadFromUser(readTypeOfVeicle, 5))
//{
//correct = true;
/*switch (int.Parse(readTypeOfVeicle))
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
try
{
	string licenceID, model, tiresModel;
	float currentGazAmount, tiresCurrentPressure;
	int intColor, intDoorsType;
	eColors color;
	eDoorsType doorsType;
	Console.WriteLine("Please enter licence id of the car:");
	licenceID = Console.ReadLine();
	Console.WriteLine("Please enter Model of the car");
	model = Console.ReadLine();
	do
	{
		Console.WriteLine("Please enter current gas amount of the car (numeric)");
	} while (!float.TryParse(Console.ReadLine(), out currentGazAmount));
	Console.WriteLine("please enter Tires Model of the car");
	tiresModel = Console.ReadLine();
	do
	{
		Console.WriteLine("Please enter Tires Current pressure of the car (numeric)");
	} while (!float.TryParse(Console.ReadLine(), out tiresCurrentPressure));
	do
	{
		Console.WriteLine("Please enter Color of the car\ngrey->1, green->2, white->3 , red->4");
	} while (!(int.TryParse(Console.ReadLine(), out intColor) && intColor >= 1 && intColor <= 4));
	color = (eColors)intColor;
	do
	{
		Console.WriteLine("Please enter doors type of the car(between 2-5)");
	} while (!((int.TryParse(Console.ReadLine(), out intDoorsType)) && intDoorsType >= 2 && intDoorsType <= 5));
	doorsType = (eDoorsType)(intDoorsType - 1);
	//Car c = new Car();
	Garage garage = new Garage();
	garage.AddCarAndFillWithDetails(eTypeOfVeichle.FuelCar, licenceID, model
		, currentGazAmount, tiresModel, tiresCurrentPressure, color,
		doorsType);
	garage.AddCustomer(FullNameCustomer, PhoneNumberCustomer, licenceID);
	Console.WriteLine("added a new car is succeess");
	Console.WriteLine("added a Cusomer is succeess");
}
catch (ValueOutOfRangeException voore)
{

	Console.WriteLine(voore.Message);
	Console.WriteLine("added a new car is failed");
	fuelCar();

}
}
private static void electricCar()
{
try
{
	string licenceID, model, tiresModel;
	float currentHoursLeftForBattery, tiresCurrentPressure;
	int intColor, intDoorsType;
	eColors color;
	eDoorsType doorsType;
	Console.WriteLine("Please enter licence id of the car:");
	licenceID = Console.ReadLine();
	Console.WriteLine("Please enter Model of the car");
	model = Console.ReadLine();
	do
	{
		Console.WriteLine("Please enter current hours lefft for battery of the car (numeric)");
	} while (!float.TryParse(Console.ReadLine(), out currentHoursLeftForBattery));
	Console.WriteLine("please enter Tires Model of the car");
	tiresModel = Console.ReadLine();
	do
	{
		Console.WriteLine("Please enter Tires Current pressure of the car (numeric)");
	} while (!float.TryParse(Console.ReadLine(), out tiresCurrentPressure));
	do
	{
		Console.WriteLine("Please enter Color of the car\ngrey->1, green->2, white->3 , red->4");
	} while (!(int.TryParse(Console.ReadLine(), out intColor) && intColor >= 1 && intColor <= 4));
	color = (eColors)intColor;
	do
	{
		Console.WriteLine("Please enter doors type of the car(between 2-5)");
	} while (!((int.TryParse(Console.ReadLine(), out intDoorsType)) && intDoorsType >= 2 && intDoorsType <= 5));
	doorsType = (eDoorsType)(intDoorsType - 1);
	//Car c = new Car();
	Garage garage = new Garage();
	garage.AddCarAndFillWithDetails(eTypeOfVeichle.ElectricCar, licenceID, model
		, currentHoursLeftForBattery, tiresModel, tiresCurrentPressure, color,
		doorsType);
	garage.AddCustomer(FullNameCustomer, PhoneNumberCustomer, licenceID);
	Console.WriteLine("added a new car is succeess");
	Console.WriteLine("added a Cusomer is succeess");
}
catch (ValueOutOfRangeException voore)
{

	Console.WriteLine(voore.Message);
	Console.WriteLine("added a new car is failed");
	electricCar();

}
}
private static void fuelMotorCycle()
{
try
{
	string licenceID, model, tiresModel;
	float currentGazAmount, tiresCurrentPressure, engineCapacity;
	int intLicenceType;
	eLiecenceType licenceType;

	Console.WriteLine("Please enter licence id of the car:");
	licenceID = Console.ReadLine();
	Console.WriteLine("Please enter Model of the car");
	model = Console.ReadLine();
	do
	{
		Console.WriteLine("Please enter current gas amount of the car (numeric)");
	} while (!float.TryParse(Console.ReadLine(), out currentGazAmount));
	Console.WriteLine("please enter Tires Model of the car");
	tiresModel = Console.ReadLine();
	do
	{
		Console.WriteLine("Please enter Tires Current pressure of the car (numeric)");
	} while (!float.TryParse(Console.ReadLine(), out tiresCurrentPressure));
	do
	{
		Console.WriteLine("Please enter licence type of the car\nA->1, A1->2, B1->3 , B2->4");
	} while (!(int.TryParse(Console.ReadLine(), out intLicenceType) && intLicenceType >= 1 && intLicenceType <= 4);
	licenceType = (eLiecenceType)(intLicenceType);
	do
	{
		Console.WriteLine("Please enter engine capacity of the car(cc)");
	} while (float.TryParse(Console.ReadLine(), out engineCapacity));
	//Car c = new Car();
	Garage garage = new Garage();
	garage.AddMotorAndFillWithDetails(eTypeOfVeichle.FuelMotorCycle, licenceID,
		model, currentGazAmount, tiresModel, tiresCurrentPressure, licenceType, engineCapacity);
	garage.AddCustomer(FullNameCustomer, PhoneNumberCustomer, licenceID);
	Console.WriteLine("added a new car is succeess");
	Console.WriteLine("added a Cusomer is succeess");
}
catch (ValueOutOfRangeException voore)
{

	Console.WriteLine(voore.Message);
	Console.WriteLine("added a new car is failed");
	fuelMotorCycle();
}
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
}*/

