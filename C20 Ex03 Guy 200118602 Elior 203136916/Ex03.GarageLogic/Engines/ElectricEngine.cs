﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    public class ElectricEngine : EngineType
    {
        public ElectricEngine(float i_MaxEnergy)
        {
            MaxEnergy = i_MaxEnergy;
            m_TypeOfEngine = eTypeOfEngine.ELECTRIC;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder()
                .AppendLine("The Max Hours Of Batter Is:" + MaxEnergy)
                .AppendLine("The Hours That Left For The Battery Are: " + CurrentEnergy);

            return sb.ToString();
        }
    }
}