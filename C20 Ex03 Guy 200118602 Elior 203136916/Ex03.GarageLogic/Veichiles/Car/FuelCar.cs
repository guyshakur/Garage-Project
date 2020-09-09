using Ex03.GarageLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class FuelCar : Car
    {
     
        //public override void InitalizeEngine(float i_CurrentEnergy)
        //{
        //    Engine = new FuelEngine(FuelType, i_CurrentEnergy, MaxEnergy);
        //}

        //public FuelCar(eFuelType i_FuelType,float i_CurrentFuel,float i_MaxFuel)
        //{
        //    FuelType = i_FuelType;
        //    EnergyPercent= i_CurrentFuel;
        //    MaxEnergy = i_MaxFuel;
        //    TypeOfVeichle = eTypeOfVeichle.FuelCar;

        //}

        public FuelCar(eFuelType i_FuelType,float i_MaxFuel)
        {
            TypeOfVeichle = eTypeOfVeichle.FuelCar;
            Engine = new FuelEngine(i_FuelType, i_MaxFuel);
            Engine.TypeOfEngine = eTypeOfEngine.FUEL;

        }
    }

}
