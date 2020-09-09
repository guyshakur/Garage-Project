using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    public class ElectricCar : Car
    {
        public ElectricCar(float i_MaxEnergy)
        {
            TypeOfVeichle = eTypeOfVeichle.ElectricCar;
            Engine = new ElectricEngine(i_MaxEnergy);
            Engine.TypeOfEngine = eTypeOfEngine.ELECTRIC;
        }

    }
}
