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
        private static List<Customer> m_Customers = null;
        private static List<Vehicle> m_Vehicles = null;

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

        public static List<Customer> Customers
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

        public static List<Vehicle> Vehicles
        {
            get
            {
                return m_Vehicles;
            }
            set
            {
                m_Vehicles = value;
            }
        }

        public void AddCustomer(string i_FullName, string i_PhoneNumber, string i_LicenceId)
        {

            if (Customers == null)
            {
                Customers = new List<Customer>();
            }
            Customer customer = new Customer(i_FullName, i_PhoneNumber, i_LicenceId);
            customer.Status = eVeichileStatus.FIXING;
            Customers.Add(customer);
        }


        public void AddCarAndFillWithDetails(eTypeOfVeichle i_TypeOfVeichile, string i_LicenceID, string i_VehicleModel, float i_EngineCurrentEnergy, string i_TiresModel, float i_CurrntTireAirPressure, eColors i_Color, eDoorsType i_DoorType)
        {
            switch (i_TypeOfVeichile)
            {

                case eTypeOfVeichle.FuelCar:
                case eTypeOfVeichle.ElectricCar:
                    if (Vehicles == null)
                    {
                        Vehicles = new List<Vehicle>();
                    }
                    if (Cars == null)
                    {
                        Cars = new List<Car>();
                    }
                    Car car = VeichileFactory.CreateCar(i_TypeOfVeichile);
                    car.LicenceID = i_LicenceID;
                    car.Model = i_VehicleModel;
                    car.Engine.CurrentEnergy = i_EngineCurrentEnergy;
                    initTires(car, i_TiresModel, i_CurrntTireAirPressure);
                    car.Colors = i_Color;
                    car.DoorType = i_DoorType;
                    Cars.Add(car);
                    Vehicles.Add(car);
                    break;

            }
        }

        public void AddMotorAndFillWithDetails(eTypeOfVeichle i_TypeOfVeichile, string i_LicenceID, string i_VehicleModel, float i_EngineCurrentEnergy, string i_TiresModel, float i_CurrntTireAirPressure, eLiecenceType i_LicenceType, int i_EngineCapacity)
        {
            switch (i_TypeOfVeichile)
            {
                case eTypeOfVeichle.FuelMotorCycle:
                case eTypeOfVeichle.ElectricMotorCycle:
                    if (Vehicles == null)
                    {
                        Vehicles = new List<Vehicle>();
                    }
                    if (Motors == null)
                    {
                        Motors = new List<MotorBike>();
                    }
                    MotorBike motor = VeichileFactory.CreateMotorBike(i_TypeOfVeichile);
                    motor.LicenceID = i_LicenceID;
                    motor.Model = i_VehicleModel;
                    motor.Engine.CurrentEnergy = i_EngineCurrentEnergy;
                    initTires(motor, i_TiresModel, i_CurrntTireAirPressure);
                    motor.LiecenceType = i_LicenceType;
                    motor.EngineCapacity = i_EngineCapacity;
                    Motors.Add(motor);
                    Vehicles.Add(motor);
                    break;
            }
        }

        public void AddTruckAndFillWithDetails(eTypeOfVeichle i_TypeOfVeichile, string i_LicenceID, string i_VehicleModel, float i_EngineCurrentEnergy, string i_TiresModel, float i_CurrntTireAirPressure, bool i_IsDangarus, float i_TruckCapacity)
        {
            switch (i_TypeOfVeichile)
            {
                case eTypeOfVeichle.Truck:
                    if (Vehicles == null)
                    {
                        Vehicles = new List<Vehicle>();
                    }
                    if (Trucks == null)
                    {
                        Trucks = new List<Truck>();
                    }
                    Truck truck = VeichileFactory.CreateTruck(i_TypeOfVeichile);
                    truck.LicenceID = i_LicenceID;
                    truck.Model = i_VehicleModel;
                    truck.Engine.CurrentEnergy = i_EngineCurrentEnergy;
                    initTires(truck, i_TiresModel, i_CurrntTireAirPressure);
                    truck.IsHazardous = i_IsDangarus;
                    truck.TruckCapacity = i_TruckCapacity;
                    Trucks.Add(truck);
                    Vehicles.Add(truck);
                    break;
            }
        }

        private void initTires(Vehicle i_Vehicle, string i_TiresModel, float i_CurrntTireAirPressure)
        {
            foreach (Tire tire in i_Vehicle.Tires)
            {
                tire.Brand = i_TiresModel;
                tire.CurrentPressure = i_CurrntTireAirPressure;
            }
        }

        public static bool IsLicenceIDExistInGarage(string i_LicenceID)
        {
            bool isExist = false;
            if (Vehicles != null)
            {
                foreach (Vehicle v in Vehicles)
                {
                    if (v.LicenceID.Equals(i_LicenceID))
                    {
                        isExist = true;
                        break;
                    }
                }

            }

            return isExist;
        }

        public static string GetAllLiecenceAndStatus()
        {
            StringBuilder sb = new StringBuilder();
            if (Vehicles == null || Vehicles.Count == 0)
            {

                sb.AppendLine("There Are No Vehicles In The Garage Yet.");
            }
            else
            {
                foreach (Customer customer in Customers)
                {
                    sb.AppendLine(customer.LicenceIDOfCar + " Status - " + customer.Status);

                }
            }
            return sb.ToString();

        }

        public static string GetAllfileredLiecenceByVehicleStatus(eVeichileStatus i_VehicleStatus)
        {
            StringBuilder sb = new StringBuilder();
            if (Vehicles != null)
            {

                foreach (Customer customer in Customers)
                {
                    if (customer.Status == i_VehicleStatus)
                    {
                        sb.AppendLine(customer.LicenceIDOfCar);
                    }
                }
                if (String.IsNullOrEmpty(sb.ToString()))
                {
                    sb.AppendLine("There Are No Vehicles With That Status");
                }
            }
            return sb.ToString();
        }

        public static bool ChangeStatusOfVehicleIfExists(string i_LiecenceID,eVeichileStatus i_VehicleStatus)
        {
            bool isExist = false;
            if(IsLicenceIDExistInGarage(i_LiecenceID))
            {
                isExist = true;
                if(GetIndexOfByLiecenceID(i_LiecenceID,Customers)!=-1)
                {
                   Customers.ElementAt(GetIndexOfByLiecenceID(i_LiecenceID,Customers)).Status = i_VehicleStatus;
                }
                
            }

            return isExist;
        }

        private static int GetIndexOfByLiecenceID(string i_LiecenceID,List<Customer>obj)
        {
            int index = -1;
            for(int i=0;i<obj.Count;i++)
            {
                if(Customers.ElementAt(i).LicenceIDOfCar.Equals(i_LiecenceID))
                {
                    index = i;
                }
            }
            return index;
        }

        

        public static void InflateTires(string i_LiecenceID)
        {

        }


    }


}
