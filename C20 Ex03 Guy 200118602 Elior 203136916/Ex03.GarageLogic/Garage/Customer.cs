using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic.Garage
{
    public class Customer
    {
        private string m_fullname;
        private string m_PhoneNumber;
        private string m_LiecenceVehicleId;
        private eVeichileStatus m_VeichileStatus;

        public string FullName
        {
            get
            {
                return m_fullname;
            }

            set
            {
                m_fullname = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return m_PhoneNumber;
            }

            set
            {
                m_PhoneNumber = value;
            }
        }

        public string LicenceIDOfCar
        {
            get
            {
                return m_LiecenceVehicleId;
            }

            set
            {
                m_LiecenceVehicleId = value;
            }
        }

        public eVeichileStatus Status
        {
            get
            {
                return m_VeichileStatus;
            }

            set
            {
                m_VeichileStatus = value;
            }
        }

        public Customer(string i_Fullname, string i_PhoneNumber, string i_LicenceCarID)
        {
            FullName = i_Fullname;
            PhoneNumber = i_PhoneNumber;
            LicenceIDOfCar = i_LicenceCarID;
        }

        public override string ToString()
        {
            return new StringBuilder().AppendLine(FullName)
                .AppendLine(PhoneNumber).ToString();
        }
    }
}
