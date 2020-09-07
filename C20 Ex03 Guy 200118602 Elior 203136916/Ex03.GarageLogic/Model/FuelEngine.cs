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
        private readonly eFuelType m_FuelType;
        private float m_CurrentFuel;
        private float m_MaxFuel;
        private GasStation m_GassStation;

        public FuelEngine(eFuelType i_FuelType, float i_CurrentEnergy, float i_MaxEnergy)
            : base(i_CurrentEnergy, i_MaxEnergy)
        {
            if(i_CurrentEnergy > i_MaxEnergy)
            {
                throw new ValueOutOfRangeException(0, i_MaxEnergy);
            }

            m_FuelType = i_FuelType;
            m_TypeOfEngine = eTypeOfEngine.FUEL;

        }

        public override void FillEnergy()
        {
            GasStation gasStation = new GasStation();
            gasStation.FillFuel(this);
        }

    }
}
