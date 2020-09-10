using System;
using Ex03.GarageLogic.Garage;
using Ex03.GarageLogic.Enums;

namespace Ex03.ConsoleUI
{
    public class DetaileOfVeichle
    {
        public static void getListOfAllLiecenceInTheGarage()
        {
            bool flag = true;
            if (Garage.GetAllLiecenceAndStatus().Length > 0)
            {
                Console.WriteLine(Garage.GetAllLiecenceAndStatus().ToString());
                do
                {
                    Console.WriteLine(
@"If you want to filter by status:
1. Fixed
2. Fixing
3. Paid
for exit (from this menu) press another key");
                    if (int.TryParse(Console.ReadLine(), out int result) && result > 0 && result < 4)
                    {
                        Console.WriteLine(
@"{0}
press any key for exit to main menu", Garage.GetAllfileredLiecenceByVehicleStatus((eVeichileStatus)result));
                        Console.ReadLine();
                    }
                    else
                    {
                        flag = false;
                    }
                } while (flag);
            }
        }

        internal static void getFullInfoAboutVeichleByLiecenceID()
        {
            Console.Clear();
            Console.WriteLine("Enter licence id for details.");
            string licenceId = Console.ReadLine();
            Console.WriteLine(
@"{0}
Enter any key to exit ", Garage.GetAllVehicleDetailIfExist(licenceId));
            Console.ReadLine();
        }
    }
}
