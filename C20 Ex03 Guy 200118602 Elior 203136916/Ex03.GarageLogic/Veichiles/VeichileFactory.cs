using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic.Enums;
using Ex03.GarageLogic.Model;

namespace Ex03.GarageLogic.Veichiles
{
    public class VeichileFactory
    {
        private static float s_MaxFuelForCar = 50f;
        private static eFuelType s_FuelTypeForCar = eFuelType.Octan96;
        private static float s_MaxTimeForBatteryForCar = 4.8f;
        private static float s_MaxFuelForBike = 5.5f;
        private static eFuelType s_FuelTypeForBike = eFuelType.Octan95;
        private static float s_MaxTimeForBatteryForBike = 1.6f;
        private static float s_MaxFuelForTruck = 105f;
        private static eFuelType s_FuelTypeForTruck = eFuelType.Soler;

        public static Car CreateCar(eTypeOfVeichle i_TypeOfVeichile)
        {
            Car car = null;
            switch (i_TypeOfVeichile)
            {
                case eTypeOfVeichle.FuelCar:
                    car = new FuelCar(s_FuelTypeForCar, s_MaxFuelForCar);
                    break;

                case eTypeOfVeichle.ElectricCar:
                    car = new ElectricCar(s_MaxTimeForBatteryForCar);
                    break;
            }

            return car;
        }

        public static MotorBike CreateMotorBike(eTypeOfVeichle i_TypeOfVeichile)
        {
            MotorBike motorBike = null;
            switch (i_TypeOfVeichile)
            {
                case eTypeOfVeichle.FuelMotorCycle:
                    motorBike = new FuelMotorBike(s_FuelTypeForBike, s_MaxFuelForBike);
                    break;

                case eTypeOfVeichle.ElectricMotorCycle:
                    motorBike = new ElectricMotorBike(s_MaxTimeForBatteryForBike);
                    break;
            }

            return motorBike;
        }

        public static Truck CreateTruck(eTypeOfVeichle i_TypeOfVeichile)
        {
            Truck truck = null;
            switch (i_TypeOfVeichile)
            {
                case eTypeOfVeichle.Truck:
                    truck = new Truck(s_FuelTypeForTruck, s_MaxFuelForTruck);
                    break;
            }

            return truck;
        }
    }
}
