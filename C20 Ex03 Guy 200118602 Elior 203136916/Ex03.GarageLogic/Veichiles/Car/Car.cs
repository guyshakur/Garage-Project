using Ex03.GarageLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class Car : Vehicle
    {
        private eColors m_Colors;
        private eDoorsType m_DoorsType;
        private eFuelType  m_FuelType;
        public eColors Colors
        {
            get
            {
                return m_Colors;
            }
            set
            {
                m_Colors = value;
            }
        }

        public eDoorsType DoorType
        {
            get
            {
                return m_DoorsType;
            }
            set
            {
                m_DoorsType = value;
            }
        }

        public eFuelType FuelType
        {
            get
            {
                return  m_FuelType;
            }
            set
            {
                m_FuelType = value;
            }
        }

    }

}

