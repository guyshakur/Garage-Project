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
        private float m_BatteryHoursLeft;
        private float m_MaxHoursOfBattery;
        

        public float BatteryHoursLeft
        {
            get
            {
                return m_BatteryHoursLeft;
            }
            set
            {
                    m_BatteryHoursLeft = value;
            }
        }

        private float m_MaxBattryHours;

        public ElectricEngine(float i_CurrentEnergy, float i_MaxEnergy) 
            : base(i_CurrentEnergy, i_MaxEnergy)
        {
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
