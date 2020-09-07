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
        private eFuelType m_FuelType;
     
        public eFuelType FuelType
        {
            get
            {
                return m_FuelType;
            }
            set
            {
                m_FuelType = value;
            }
        }
      
        public override void InitalizeEngine(float i_CurrentEnergy)
        {
            EngineType engine = new FuelEngine(FuelType, i_CurrentEnergy, MaxEnergy);
        }

        public FuelCar(eFuelType i_FuelType,float i_CurrentFuel,float i_MaxFuel)
        {
            FuelType = i_FuelType;
            EnergyPercent= i_CurrentFuel;
            MaxEnergy = i_MaxFuel;
            TypeOfVeichle = eTypeOfVeichle.FuelCar;

        }
    }

}
