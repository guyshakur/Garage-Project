using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    public class FuelCar : Car
    {
        public FuelCar(eFuelType i_FuelType, float i_MaxFuel)
        {
            TypeOfVeichle = eTypeOfVeichle.FuelCar;
            Engine = new FuelEngine(i_FuelType, i_MaxFuel);
            Engine.TypeOfEngine = eTypeOfEngine.FUEL;
        }
    }
}
