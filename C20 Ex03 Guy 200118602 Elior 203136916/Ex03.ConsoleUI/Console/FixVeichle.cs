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
            Console.WriteLine("Insert Liecence Id of Vehicle  ");
            string licenceFromUser = Console.ReadLine();
            if (Garage.IsLicenceIDExistInGarage(licenceFromUser))
            {
                Console.WriteLine("The status that you want to change to  ");
                Console.WriteLine("1. Fixed\n" +
                            "2. Fixing\n" +
                           "3. Paid\n" +
                           "for exit (from this menu) press another key");
                if (int.TryParse(Console.ReadLine(), out int result) && result > 0 && result < 4)
                {
                    if (!Garage.ChangeStatusOfVehicleIfExists(licenceFromUser, (eVeichileStatus)result))
                    {
                        Console.WriteLine("this Licence id not exist."); ;
                    }
                    else
                    {
                        Console.WriteLine("status changed");
                    }
                }
            }
			else
			{
                Console.WriteLine("this Licence id not exist.");
            }
            Console.WriteLine("for exit press any key");
            Console.ReadLine();

        }

		internal static void chargeBattery()
		{
			
		}

		internal static void fuelCarWithGas()
		{

		}

		internal static void inflateTires()
		{
            Console.WriteLine("Press Liecence Id of Vehicle for inflate tires ");
            string licenceFromUser = Console.ReadLine();
            if(Garage.InflateTiresToTheMaxIfExist(licenceFromUser))
            {
                Console.WriteLine("The tires are inflated to the maximum");
            }
			else
			{
                Console.WriteLine("There are no veichle with this Liecence ID");
			}
            Console.WriteLine("for exit pres any key");
            Console.ReadLine();
        }
	}
}
