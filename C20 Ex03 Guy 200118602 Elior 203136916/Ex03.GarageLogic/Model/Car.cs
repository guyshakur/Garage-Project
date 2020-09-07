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

        public eDoorsType DoorNumber
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

    }

}

