using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic.Enums;
using Ex03.GarageLogic.Model;

namespace Ex03.GarageLogic.Veichiles
{
    public class ElectricMotorBike : MotorBike
    {
        public ElectricMotorBike(float i_MaxEnergy)
        {
            TypeOfVeichle = eTypeOfVeichle.ElectricMotorCycle;
            Engine = new ElectricEngine(i_MaxEnergy);
            Engine.TypeOfEngine = eTypeOfEngine.ELECTRIC;
        }
    }
}
