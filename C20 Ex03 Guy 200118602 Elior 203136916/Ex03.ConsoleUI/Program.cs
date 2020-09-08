using Ex03.GarageLogic;
using Ex03.GarageLogic.Enums;
using Ex03.GarageLogic.Garage;
using Ex03.GarageLogic.Veichiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{
    class Program
    {

        public static void Main()
        {
            Garage g = new Garage();

            eTypeOfVeichle type = eTypeOfVeichle.Truck;
            g.AddTruckAndFillWithDetails(type, "564", "mazda", 105.0f, "bb", 15.9f,false,56.9f);
            Console.WriteLine(g.Vehicles.ElementAt(0).ToString());     

           //GarageConsole.Garage(); 
        }

    }
}
