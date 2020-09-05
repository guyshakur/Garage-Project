using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        private string m_Model;

        public string Model
        {
            set
            {
                m_Model = value ;
            }
            get
            {
                return m_Model;
            }

        }

        private string m_LicenceID;

        public string LicenceID
        {
            set
            {
                m_LicenceID = value;
            }
            get
            {
                return m_LicenceID;
            }
        }

        private float m_EnergyPercent;

        public float EnergyPercent
        {
            get
            {
                return m_EnergyPercent;
            }

            set
            {
                m_EnergyPercent = value;
            }
        }

        private List<Tire> m_wheels;

        public List<Tire> Tires
        {
            get
            {
                return m_wheels;
            }
            set
            {
                m_wheels = value;
            }
        }
    }
}
