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

        public override void InitalizeEngine(float i_CurrentEnergy)
        {
            EngineType engine = new ElectricEngine(i_CurrentEnergy, MaxEnergy);
        }

        public ElectricCar(float i_CurrentBatteryHours, float i_MaxBatteryHours)
        {
            
            EnergyPercent = i_CurrentBatteryHours;
            MaxEnergy = i_MaxBatteryHours;
            TypeOfVeichle = eTypeOfVeichle.ElectricCar;

        }
    }
}
