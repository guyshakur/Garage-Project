using Ex03.GarageLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic.Model
{
    public abstract class MotorBike:Vehicle
    {
        private eLiecenceType m_LiecenceType;
        private int m_EngineCapacity;
        private eFuelType ? m_FuelType;

        public eLiecenceType LiecenceType
        {
            get
            {
                return m_LiecenceType;
            }
            set
            {
                m_LiecenceType = value;
            }
        }

        public int EngineCapacity
        {
            get
            {
                return m_EngineCapacity;
            }
            set
            {
                m_EngineCapacity = value;
            }
        }

        public eFuelType FuelType
        {
            get
            {
                return (eFuelType)m_FuelType;
            }
            set
            {
                m_FuelType = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Licence Type: " + LiecenceType.ToString());
            sb.AppendLine("Engine Capacity: " + EngineCapacity);

            return sb.ToString();
        }
    }
}
