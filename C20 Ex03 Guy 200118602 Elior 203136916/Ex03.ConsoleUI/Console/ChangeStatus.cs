using Ex03.GarageLogic.Enums;
using Ex03.GarageLogic.Garage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{
    class ChangeStatus
    {
        public static void ChangeVehicleStatus()
        {
            Console.WriteLine("Insert Liecence Id of Vehicle  ");
            string licenceFromUser = Console.ReadLine();
            Console.WriteLine("The status that you want to change to  ");
            Console.WriteLine("1. Fixed\n" +
                        "2. Fixing\n" +
                       "3. Paid\n" +
                       "for exit (from this menu) press another key");
            if (int.TryParse(Console.ReadLine(), out int result) && result > 0 && result < 4)
            {
                if (!Garage.ChangeStatusOfVehicleIfExists(licenceFromUser, (eVeichileStatus)result))
                {
                    Console.WriteLine("this Licence id not exist.\n" + "for exit press any key");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("status changed");
                    Console.WriteLine("for exit pres any key");
                    Console.ReadLine();
                }
            }

        }
    }
}
