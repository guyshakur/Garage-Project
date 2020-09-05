using System;

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

        public float MaxPeerPressure
        {
            get
            {
                return m_MaxPeerPressure;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Only positive value are allowed");
                }
                else
                {
                    m_MaxPeerPressure = value;
                }
            }
        }

        public Tire(string i_Brand,float i_CurrentPeerPressure,float i_MaxPeerPressue)
        {
            Brand= i_Brand;
            CurrentPeerPressure = i_CurrentPeerPressure;
            MaxPeerPressure = i_MaxPeerPressue;


        }

        public void InflateTire(float i_AmountOfAirToAdd)
        {
            if (i_AmountOfAirToAdd + CurrentPeerPressure > MaxPeerPressure)
            {
                throw new ArgumentException("The max peer pressure for this tire is " + MaxPeerPressure);
            }
            else
            {
                CurrentPeerPressure += i_AmountOfAirToAdd;
            }

        }

    }
}