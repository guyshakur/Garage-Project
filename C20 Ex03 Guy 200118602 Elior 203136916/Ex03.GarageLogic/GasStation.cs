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

        private float m_AmountOfEnergy;

        private eFuelType ? m_FuelType;

        public GasStation()
        {
            m_FuelType = null;
        }

        //singeltone
        //public static GasStation Instance
        //{
        //    get
        //    {
        //        return m_Instance ?? (m_Instance = new GasStation());
        //    }
        //}

        public eFuelType? CurrentFuelType
        {
            get
            {
                return m_FuelType;
            }
        }

        //overload methods 
        public void SetForEnergy(eFuelType i_FuelType, float i_Liters)
        {
            m_FuelType = i_FuelType;
            m_AmountOfEnergy = i_Liters;
        }

        public void SetForEnergy(float i_HoursToFill)
        {
            m_FuelType = null;
            m_AmountOfEnergy = i_HoursToFill;
        }

        public void FillFuel(EngineType i_EngineType)
        {
            i_EngineType.CurrentEnergy += m_AmountOfEnergy;
        }

        public void ChargeBattery(EngineType i_EngineType)
        {
            i_EngineType.CurrentEnergy += m_AmountOfEnergy;
        }
    }


}
