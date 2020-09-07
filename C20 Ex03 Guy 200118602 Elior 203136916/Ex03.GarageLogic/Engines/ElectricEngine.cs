using Ex03.GarageLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class ElectricEngine : EngineType
    {

        private float m_MaxBattryHours;

        public ElectricEngine(float i_MaxEnergy) 
        {
            MaxEnergy = i_MaxEnergy;
            m_TypeOfEngine = eTypeOfEngine.ELECTRIC;
        }

        public float MaxBattryHours
        {
            get
            {
                return m_MaxBattryHours;
            }
            set
            {
                m_MaxBattryHours = value;
            }
        }

        public override void FillEnergy()
        {
            GasStation gasStation = new GasStation();
            gasStation.ChargeBattery(this);

        }

    }
}
