using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{

    public class ValueOutOfRangeException : Exception
    {
        private float m_MaxValue;
        private float m_MinValue;

        public float MaxValue
        {
            get
            {
                return m_MaxValue;
            }
            set
            {
                m_MaxValue = value;
            }

        }

        public float MinValue
        {
            get
            {
                return m_MinValue;
            }
            set
            {
                m_MinValue = value;
            }

        }

        public ValueOutOfRangeException(string i_NameOfValue,float i_MinValue, float i_MaxValue)
            : base(i_NameOfValue+" "+ "must be in the range of " + 0f + " to " + i_MaxValue)

        {
            MinValue = i_MinValue;
            m_MaxValue = i_MinValue;

    }

    }
}
    