using System;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Tire
    {
        private string m_Brand;
        private float m_MaxPressure;
        private float m_CurrentPressure;

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

        public float CurrentPressure
        {
            get
            {
                return m_CurrentPressure;
            }

            set
            {
                if (value > MaxPressure)
                {
                    throw new ValueOutOfRangeException("Max Pressure", 0, MaxPressure);
                }
                else
                {
                    m_CurrentPressure = value;
                }
            }
        }

        public float MaxPressure
        {
            get
            {
                return m_MaxPressure;
            }

            set
            {
                m_MaxPressure = value;
            }
        }

        public Tire(float i_MaxPressure,string i_Brand)
        {
            i_Brand = Brand;
            MaxPressure = i_MaxPressure;
        }

        public void InflateTire(float i_AmountOfAirToAdd)
        {
            if (i_AmountOfAirToAdd + CurrentPressure > MaxPressure)
            {
                throw new ValueOutOfRangeException("Amount Of Air", 0, MaxPressure - MaxPressure);
            }
            else
            {
                CurrentPressure += i_AmountOfAirToAdd;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tire Brand: " + Brand);
            sb.AppendLine("Tire Max Pressure: " + MaxPressure);
            sb.AppendLine("tire Current Pressure: " + CurrentPressure);

            return sb.ToString();
        }
    }
}