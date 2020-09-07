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
        private float m_EngineCapacity;

        public eLiecenceType LiecenceType { get; set; }

        public float EngineCapacity { get; set; }
    }
}
