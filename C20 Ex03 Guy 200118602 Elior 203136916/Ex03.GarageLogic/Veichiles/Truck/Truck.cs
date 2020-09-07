using Ex03.GarageLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic.Veichiles
{
    public class Truck : Vehicle
    {
        private eFuelType m_FuelType;
        private bool m_IsHazardous;
        private float m_TruckCapacity;

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

        public bool IsHazardous
        {
            get
            {
                return m_IsHazardous;
            }
            set
            {
                m_IsHazardous = value;
            }
        }

        public float TruckCapacity
        {
            get
            {
                return m_TruckCapacity;
            }
            set
            {
                m_TruckCapacity = value;
            }
        }
            
        
        public override void InitalizeEngine(float i_CurrentEnergy)
        {
            Engine = new FuelEngine(FuelType, i_CurrentEnergy, MaxEnergy);
        }

        public Truck(eFuelType i_FuelType)
        {
            FuelType = i_FuelType;
        }
    }
}
