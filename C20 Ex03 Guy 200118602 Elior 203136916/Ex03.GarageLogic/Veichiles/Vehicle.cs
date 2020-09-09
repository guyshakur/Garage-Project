using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        private string m_Model;
        private string m_LicenceID;
        private List<Tire> m_Tires;
        private eTypeOfVeichle m_TypeOfVehicle;

        public string Model
        {
            get
            {
                return m_Model;
            }

            set
            {
                m_Model = value;
            }
        }

        public string LicenceID
        {
            get
            {
                return m_LicenceID;
            }

            set
            {
                m_LicenceID = value;
            }
        }

        public eTypeOfVeichle TypeOfVeichle
        {
            get
            {
                return m_TypeOfVehicle;
            }

            set
            {
                m_TypeOfVehicle = value;
            }
        }

        public List<Tire> Tires
        {
            get
            {
                return m_Tires;
            }

            set
            {
                m_Tires = value;
            }
        }

        public EngineType Engine
        {
            get
            {
                return m_EngineType;
            }

            set
            {
                m_EngineType = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb =
                new StringBuilder().AppendLine("Vehicle Full Details:")
                .AppendLine("Type: " + TypeOfVeichle)
                .AppendLine("Licence ID: " + LicenceID)
                .AppendLine("Model: " + Model)
                .AppendLine("Engine Details: ")
                .AppendLine(Engine.ToString())
                .AppendLine("Tires Details:");
            
            foreach (Tire tire in Tires)
            {
                sb.AppendLine(tire.ToString());
            }

            return sb.ToString();
        }
    }
}
