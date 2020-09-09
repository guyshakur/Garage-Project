using System;
using Ex03.GarageLogic.Garage;
using Ex03.GarageLogic.Enums;

namespace Ex03.ConsoleUI
{
    class DetaileOfVeichle
    {
        public static void getListOfAllLiecenceInTheGarage()
        {
            bool flag = true;
            if (Garage.GetAllLiecenceAndStatus().Length > 0)
            {
                Console.WriteLine(Garage.GetAllLiecenceAndStatus().ToString());
                do
                {
                    Console.WriteLine("If you want to filter by status:\n" +
                        "1. Fixed\n" +
                        "2. Fixing\n" +
                        "3. Paid\n" +
                        "for exit (from this menu) press another key");
                    if (int.TryParse(Console.ReadLine(), out int result) && result > 0 && result < 4)
                    {
                        Console.WriteLine(Garage.GetAllfileredLiecenceByVehicleStatus((eVeichileStatus)result));
                        System.Threading.Thread.Sleep(1500);
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
            throw new NotImplementedException();
        }
    }
}
