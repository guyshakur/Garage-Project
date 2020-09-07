using Ex03.GarageLogic;
using Ex03.GarageLogic.Enums;
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
            Car c = VeichileFactory.CreateCar(eTypeOfVeichle.FuelCar);
            c.LicenceID = "555";
            c.EnergyPercent = 2;
            c.Tires.ElementAt(0).CurrentPressure = 1;
            Console.WriteLine(c.Engine.MaxEnergy + " " + c.LicenceID+" "+c.EnergyPercent+" "+c.Tires.ElementAt(0).CurrentPressure);
            
        }

    }
}
