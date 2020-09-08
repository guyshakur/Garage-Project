using Ex03.GarageLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class EngineType
    {
        private float m_MaxEnergy;
        private float m_CurrentEnergy;
        protected eTypeOfEngine m_TypeOfEngine;
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

        public float MaxEnergy
        {
            get
            {
                return m_MaxEnergy;
            }
            set
            {
                m_MaxEnergy = value;
            }
        }

        public float CurrentEnergy
        {
            get
            {
                return m_CurrentEnergy;
            }
            set
            {
                if(value>MaxEnergy)
                {
                    throw new ValueOutOfRangeException(0, MaxEnergy);
                }
                else
                {
                    m_CurrentEnergy = value;
                }
                
            }
        }

        public eTypeOfEngine TypeOfEngine
        {
            get
            {
                return m_TypeOfEngine;
            }
        }

        public abstract void FillEnergy();

     

    }
}
