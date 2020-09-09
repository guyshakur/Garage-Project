using Ex03.GarageLogic;
using Ex03.GarageLogic.Enums;
using Ex03.GarageLogic.Garage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{
	class FixVeichle
	{
		public static void ChangeVehicleStatus()
		{
			StringBuilder msg = new StringBuilder("this Licence id not exist.");
			Console.WriteLine("Insert Liecence Id of Vehicle");
			string licenceFromUser = Console.ReadLine();
			if (Garage.IsLicenceIDExistInGarage(licenceFromUser))
			{
				Console.WriteLine(
@"The status that you want to change to
1. Fixed
2. Fixing
3. Paid
for exit (from this menu) press another key");

				if (int.TryParse(Console.ReadLine(), out int result) && result > 0 && result < 4)
				{
					if (Garage.ChangeStatusOfVehicleIfExists(licenceFromUser, (eVeichileStatus)result))
					{
						msg.Clear();
						msg.Append("status changed.");
					}
				}
			}
			msg.AppendLine("for exit press any key");
			Console.WriteLine(msg);
			Console.ReadLine();

		}

		internal static void chargeBattery()
		{
			float amountToCharge;
			Console.WriteLine("Insert Liecence Id of Vehicle");
			string licenceId = Console.ReadLine();
			if (Garage.IsLicenceIDExistInGarage(licenceId))
			{
				do
				{
					Console.WriteLine("enter hours of charging");
				} while (float.TryParse(Console.ReadLine(), out amountToCharge));
				try
				{
					Garage.ChargeVehicleIfExist(licenceId, amountToCharge);
				}
				catch (ValueOutOfRangeException ofe) //if you fill over
				{
					Console.WriteLine(ofe.Message);
					string read;
					do
					{
						Console.WriteLine("You want to fill full(y / n)?");
						read = Console.ReadLine();
					} while (!(read == "Y" || read == "y" || read == "n" || read == "N"));
					if (read == "y" || read == "Y")
					{
						Garage.GetFullEnergy(licenceId);
					}
					else
					{
						chargeBattery();
					}
				}
				catch (FormatException)//if choose gas
				{
					Console.WriteLine(
@"your veichiles is gaz and not electric.
we return to main menu.");
				} 
				finally
				{
					Console.WriteLine("Press any key for exit to menu");
					Console.ReadLine();
				}
			}
			else
			{
				Console.WriteLine("There are no veichle with this Liecence ID");
			}
		}

		internal static void fuelCarWithGas()
		{
			try
			{

			}
			catch (ValueOutOfRangeException)//if you fill over 
			{ }
			catch (FormatException)//if choose Electric
			{ }
			catch (ArgumentException)//if choose type of gaz Different
			{ }
		}

		internal static void inflateTires()
		{
			StringBuilder msg;
			Console.WriteLine("Press Liecence Id of Vehicle for inflate tires ");
			string licenceFromUser = Console.ReadLine();
			if (Garage.InflateTiresToTheMaxIfExist(licenceFromUser))
			{
				msg = new StringBuilder("The tires are inflated to the maximum");
			}
			else
			{
				msg = new StringBuilder("There are no veichle with this Liecence ID");
			}
			msg.AppendLine("for exit pres any key");
			Console.WriteLine(msg);
			Console.ReadLine();
		}
	}
}
