﻿using Ex03.GarageLogic.Enums;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        private string m_Model;
        private string m_LicenceID;
        private List<Tire> m_Tires;
        private EngineType m_EngineType;
        private eTypeOfVeichle m_TypeOfVehicle;
        private eTypeOfEngine m_TypeOfEngine;

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

        //public float EnergyPercent
        //{
        //    get
        //    {
        //        return m_EnergyPercent;
        //    }

        //    set
        //    {
        //        if(value>Engine.MaxEnergy)
        //        {
        //            throw new ValueOutOfRangeException(0, Engine.MaxEnergy);
        //        }
        //        else
        //        {
        //            m_EnergyPercent = value;
        //        }
                
        //    }
        //}

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

        //public float MaxEnergy
        //{
        //    get
        //    {
        //        return m_MaxEnergy;
        //    }
        //    set
        //    {
        //        m_MaxEnergy = value;
        //    }
        //}

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

        public eTypeOfEngine TypeOfEngine
        {
            get
            {
                return m_TypeOfEngine;
            }
            set
            {
                m_TypeOfEngine = value;
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