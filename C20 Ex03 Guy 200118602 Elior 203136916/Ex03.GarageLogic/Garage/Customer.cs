using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic.Garage
{
    public class Customer
    {
        private string m_fullname;
        private string m_PhoneNumber;
        private string m_LiecenceVehicleId;

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

        private string LicenceIDOfCar
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

        public Customer(string i_Fullname,string i_PhoneNumber,string i_LicenceCarID)
        {
            FullName = i_Fullname;
            PhoneNumber = i_PhoneNumber;
            LicenceIDOfCar = i_LicenceCarID;
        }
            
    }
}
