using Ex03.GarageLogic.Enums;
using Ex03.GarageLogic.Model;
using Ex03.GarageLogic.Veichiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic.Garage
{
    public class Garage
    {
        private Car m_Car = null;
        private MotorBike m_MotorBike = null;
        private Truck m_Truck = null;
        private List<Car> m_Cars = null;
        private List<Truck> m_Trucks = null;
        private List<MotorBike> m_Motors = null;
        private List<Customer> m_Customers = null;

        public Car Car
        {
            get
            {
                return m_Car;
            }
            set
            {
                m_Car = value;
            }
        }

        public MotorBike MotorBike
        {
            get
            {
                return m_MotorBike;
            }
            set
            {
                m_MotorBike = value;
            }
        }

        public Truck Truck
        {
            get
            {
                return m_Truck;
            }
            set
            {
                m_Truck = value;
            }
        }


        public List<Car> Cars
        {
            get
            {
                return m_Cars;
            }
            set
            {
                m_Cars = value;
            }
        }

        public List<MotorBike> Motors
        {
            get
            {
                return m_Motors;
            }
            set
            {
                m_Motors = value;
            }
        }

        public List<Truck> Trucks
        {
            get
            {
                return m_Trucks;
            }
            set
            {
                m_Trucks = value;
            }
        }

        public List<Customer> Customers
        {
            get
            {
                return m_Customers;
            }
            set
            {
                m_Customers = value;
            }
        }

        public void AddCustomer(string i_FullName, string i_PhoneNumber, string i_LicenceId)
        {
            if (Customers == null)
            {
                Customers = new List<Customer>();
            }
            Customers.Add(new Customer(i_FullName, i_PhoneNumber, i_LicenceId));
        }

        public void AddVehicleAndFillWithData(eTypeOfVeichle i_TypeOfVeichile, string i_LicenceID, string i_VehicleModel, float i_EngineCurrentEnergy, string i_TiresModel, float i_CurrntTireAirPressure)
        {
            switch (i_TypeOfVeichile)
            {
                case eTypeOfVeichle.FuelCar:
                case eTypeOfVeichle.ElectricCar:
                    if (Cars == null)
                    {
                        Cars = new List<Car>();
                    }
                    Car car = VeichileFactory.CreateCar(i_TypeOfVeichile);
                    car.LicenceID = i_LicenceID;
                    car.Model = i_VehicleModel;
                    car.Engine.CurrentEnergy = i_EngineCurrentEnergy;
                    
                   
                    Cars.Add(car);
                    break;

                case eTypeOfVeichle.FuelMotorCycle:
                case eTypeOfVeichle.ElectricMotorCycle:
                    if(Motors==null)
                    {
                        Motors = new List<MotorBike>();
                    }
                    MotorBike motor = VeichileFactory.CreateMotorBike(i_TypeOfVeichile);
                    motor.LicenceID = i_LicenceID;
                    motor.Model = i_VehicleModel;
                    break;
            }
        }

        private void fillCarWithData()
        {
            throw new NotImplementedException();
        }
    }
}
