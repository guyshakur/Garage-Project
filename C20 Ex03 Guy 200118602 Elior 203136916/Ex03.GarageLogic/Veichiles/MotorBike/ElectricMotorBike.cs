using Ex03.GarageLogic.Enums;
using Ex03.GarageLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic.Veichiles
{
    public class ElectricMotorBike : MotorBike
    {

        //public override void InitalizeEngine(float i_CurrentEnergy)
        //{
        //    Engine = new ElectricEngine(i_CurrentEnergy, MaxEnergy);
        //}

        public ElectricMotorBike(float i_MaxEnergy)
        {
            TypeOfVeichle = eTypeOfVeichle.ElectricMotorCycle;
            Engine = new ElectricEngine(i_MaxEnergy);
        }
    }
}
