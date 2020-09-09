using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic.Model
{
    public class FuelMotorBike : MotorBike
    {
        public FuelMotorBike(eFuelType i_FuelType, float i_MaxEnergy)
        {
            TypeOfVeichle = eTypeOfVeichle.FuelMotorCycle;
            Engine = new FuelEngine(i_FuelType, i_MaxEnergy);
            Engine.TypeOfEngine = eTypeOfEngine.FUEL;
        }
    }
}
