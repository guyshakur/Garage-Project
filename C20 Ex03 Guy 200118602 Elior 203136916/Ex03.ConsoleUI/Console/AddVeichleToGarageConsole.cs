using System;
using System.Security.AccessControl;
using System.Collections.Generic;
using Ex03.GarageLogic;
using Ex03.GarageLogic.Enums;
using Ex03.GarageLogic.Garage;

namespace Ex03.ConsoleUI
{
	public class AddVeichleToGarageConsole
	{
		public static eTypeOfVeichle AddVeichleToGarageMenu()
		{

			string phoneNumber, fullName;
			string licenceID, model;
			float currentGazAmountOrHoursLeftForBattery, capacity = 0;
			int intColor, intDoorsType, readTypeOfVeicle, intLicenceType;
			bool conrainsIsDanger = false;
			List<Tire> tire = new List<Tire>();
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
				do
				{
					Console.WriteLine("Please enter your full name.(only letters)");
					fullName = Console.ReadLine();
				} while (String.IsNullOrWhiteSpace(fullName) || isStringContainsNumsOrSigns(fullName));

				do
				{
					Console.WriteLine("Please enter your phone number(numbers only no spaces)");
					phoneNumber = Console.ReadLine();
				} while (String.IsNullOrWhiteSpace(phoneNumber) || !isStringContainsOnlyNumerics(phoneNumber));

				Console.WriteLine("Please enter Model of the car");
				model = Console.ReadLine();
				do
				{
					if ((eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelCar ||           //1
						(eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelMotorCycle ||    //3
						(eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.Truck)               //5
					{
						Console.WriteLine("Please enter current gas amount of the car (Numeric)");
					}
					else                                                                        //2,4
					{
						Console.WriteLine("Please enter current hours lefft for battery of the car (numeric)");
					}
				} while (!float.TryParse(Console.ReadLine(), out currentGazAmountOrHoursLeftForBattery));
				initTires(out tire, (eTypeOfVeichle)readTypeOfVeicle);

				if ((eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelCar ||           //1
					(eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.ElectricCar)         //2
				{
					do
					{
						Console.WriteLine(
@"Please enter Color of the car
1. grey
2. green
3. white
4. red");
					} while (!(int.TryParse(Console.ReadLine(), out intColor) && intColor >= 1 && intColor <= 4));
					color = (eColors)intColor;
				}
				else if ((eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelMotorCycle ||   //3
					(eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.ElectricMotorCycle)      //4
				{
					do
					{
						Console.WriteLine(
@"Please enter licence type of the car
1. A
2. A1
3. B1
4. B2");
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
							model, currentGazAmountOrHoursLeftForBattery, tire,
							color, doorType);
						Console.WriteLine("added a new car is succeess");
					}
					else if ((eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelMotorCycle ||   //3
					(eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.ElectricMotorCycle)          //4
					{
						garage.AddMotorAndFillWithDetails((eTypeOfVeichle)readTypeOfVeicle,
							licenceID, model, currentGazAmountOrHoursLeftForBattery,
							tire, liecenceType, (int)capacity);
						Console.WriteLine("added a new motorecycle is succeess");
					}
					else                                                                            //5
					{
						garage.AddTruckAndFillWithDetails(eTypeOfVeichle.Truck, licenceID,
							model, currentGazAmountOrHoursLeftForBattery, tire, conrainsIsDanger, capacity);
						Console.WriteLine("added a new truck is succeess");
					}
					garage.AddCustomer(fullName, phoneNumber, licenceID);
				}
				catch (ValueOutOfRangeException ex)
				{
					Console.WriteLine(
@"


{0}
added a new car/motorcycle/truck is failed.", ex.Message);
					return AddVeichleToGarageMenu();
				}
				finally
				{
					Console.WriteLine("for exit to main menu press any key");
					Console.ReadLine();
				}
			}
			else
			{
				Garage.ChangeStatusOfVehicleIfExists(licenceID, eVeichileStatus.FIXING);
				Console.WriteLine("The Licence ID is exists - changing the status vehicle to fixing");
			}

			return (eTypeOfVeichle)readTypeOfVeicle;
		}

		private static bool isStringContainsOnlyNumerics(string i_String)
		{
			bool isStringOnlyNumerics = true;
			foreach (char c in i_String)
			{
				if (!Char.IsDigit(c))
				{
					isStringOnlyNumerics = false;
					break;
				}
			}
			return isStringOnlyNumerics;
		}

		private static bool isStringContainsNumsOrSigns(string i_String)
		{
			bool isContainsNumberOrSigns = false;
			foreach (char c in i_String)
			{
				if (!Char.IsLetter(c) && c != ' ')
				{
					isContainsNumberOrSigns = true;
				}
			}
			return isContainsNumberOrSigns;
		}


		private static string addVeichleChoice()
		{

			string readFromUser;
			do
			{
				Console.Clear();
				Console.WriteLine(
@"     Add Veichle To Garage
please choose:
1. Fuel Car
2. Electric Car
3. Fuel MotorCycle
4. Electric MotorCycle
5. Truck");
				readFromUser = Console.ReadLine();
			} while (!GarageConsole.checkReadFromUser(readFromUser, 5));
			return readFromUser;

		}

		private static void initTires(out List<Tire> o_Tires, eTypeOfVeichle i_TypeOfVeichle)
		{
			o_Tires = Garage.CreateTires(i_TypeOfVeichle);
			foreach (Tire tire in o_Tires)
			{
				float tiresCurrentPressure;
				Console.WriteLine("please enter Tires Model of the car");
				tire.Brand = Console.ReadLine();
				do
				{
					Console.WriteLine("Please enter Tires Current pressure of the car (numeric)");
				} while (!float.TryParse(Console.ReadLine(), out tiresCurrentPressure));
				tire.CurrentPressure = tiresCurrentPressure;
			}
		}
	}
}
