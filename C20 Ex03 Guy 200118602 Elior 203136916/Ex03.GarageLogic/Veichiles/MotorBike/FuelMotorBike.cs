using Ex03.GarageLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic.Model
{
    
    public class FuelMotorBike : MotorBike
    {

        //public override void InitalizeEngine(float i_CurrentFuel)
        //{
        //    Engine = new FuelEngine(FuelType, i_CurrentFuel, MaxEnergy);
        //}

        public FuelMotorBike(eFuelType i_FuelType, float i_CurrentFuel, float i_MaxFuel)
        {
            FuelType = i_FuelType;
            EnergyPercent = i_CurrentFuel;
            MaxEnergy = i_MaxFuel;
            TypeOfVeichle = eTypeOfVeichle.FuelMotorCycle;
        }

        public FuelMotorBike(eFuelType i_FuelType,float i_MaxEnergy)
        {
            Engine = new FuelEngine(i_FuelType, i_MaxEnergy);
        }
    }
}
