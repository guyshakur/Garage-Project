﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic.Enums;

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

        public Truck(eFuelType i_FuelType, float i_MaxEnergy)
        {
            TypeOfVeichle = eTypeOfVeichle.Truck;
            Engine = new FuelEngine(i_FuelType, i_MaxEnergy);
            Engine.TypeOfEngine = eTypeOfEngine.FUEL;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Is Hazardous? " + IsHazardous);
            sb.AppendLine("Truck Capacity: " + TruckCapacity);

            return sb.ToString();
        }
    }
}
