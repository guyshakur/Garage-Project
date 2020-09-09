using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic

{
    public class GasStation
    {
        private eFuelType? m_FuelType;

        public GasStation()
        {
            m_FuelType = null;
        }

        public eFuelType? CurrentFuelType
        {
            get
            {
                return m_FuelType;
            }
        }

        internal static void FillFuel(EngineType i_Engine, eFuelType i_FuelType, float i_AmountToFill)
        {
            if (i_FuelType != i_Engine.FuelType)
            {
                throw new ArgumentException("The fuel type is not the correct one. the correct one is: " + i_Engine.FuelType.ToString());
            }
            if (i_Engine.CurrentEnergy + i_AmountToFill > i_Engine.MaxEnergy)
            {
                throw new ValueOutOfRangeException("amount of gas", 0, i_Engine.MaxEnergy - i_Engine.CurrentEnergy);
            }

            i_Engine.CurrentEnergy += i_AmountToFill;
        }

        internal static void FillToTheMax(EngineType i_Engine)
        {
            i_Engine.CurrentEnergy = i_Engine.MaxEnergy;
        }

        internal static void ChargeBattery(EngineType i_Engine, float i_AmountHoursToCharge)
        {
            if (i_Engine.CurrentEnergy + i_AmountHoursToCharge > i_Engine.MaxEnergy)
            {
                throw new ValueOutOfRangeException("hours to charge", 0, i_Engine.MaxEnergy - i_Engine.CurrentEnergy);
            }

            i_Engine.CurrentEnergy += i_AmountHoursToCharge;
        }
    }

}
