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
            g.AddVehicleAndFillWithData(type, "564", "mazda", 25.3f, "bb", 15.9f,false,415f);
            g.ToString();     

           //GarageConsole.Garage(); 
        }

    }
}
