using System;
using System.Runtime.Remoting.Messaging;

namespace Ex03.GarageLogic
{
    public class Tire
    {
        private string m_Brand;

        public string Brand
        {
            get
            {
                return m_Brand;
            }
            set
            {
                m_Brand = value;
            }
        }

        private float m_CurrentPeerPressure;

        public float CurrentPeerPressure
        {
            get
            {
                return m_CurrentPeerPressure;
            }
            set
            {
                m_CurrentPeerPressure = value;
            }

        }

        private float m_MaxPeerPressure;

        public float MaxPressure
        {
            get
            {
                return m_MaxPeerPressure;
            }
            set
            {
                m_MaxPeerPressure = value;
            }
        }

        public Tire(string i_Brand, float i_CurrentPeerPressure, float i_MaxPeerPressue)
        {
            Brand = i_Brand;
            CurrentPeerPressure = i_CurrentPeerPressure;
            MaxPressure = i_MaxPeerPressue;
        }

        public void InflateTire(float i_AmountOfAirToAdd)
        {
            if (i_AmountOfAirToAdd + CurrentPeerPressure > MaxPressure)
            {
                throw new ValueOutOfRangeException(0, MaxPressure);
            }
            else
            {
                CurrentPeerPressure += i_AmountOfAirToAdd;
            }

        }

    }
}