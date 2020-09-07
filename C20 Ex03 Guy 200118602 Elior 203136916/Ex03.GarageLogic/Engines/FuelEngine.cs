using Ex03.GarageLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class FuelEngine : EngineType
    {
        public FuelEngine(eFuelType i_FuelType, float i_MaxEnergy) 
        {
            FuelType = i_FuelType;
            MaxEnergy = i_MaxEnergy;
            m_TypeOfEngine = eTypeOfEngine.FUEL;
        }

        public override void FillEnergy()
        {
            GasStation gasStation = new GasStation();
            gasStation.FillFuel(this);
        }

    }
}
