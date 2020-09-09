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
        private static int s_NumberOfTiresForCar = 4;
        private static float s_MaxTirePressureForCar = 32f;
        private static float s_MaxFuelForCar = 50f;
        private static eFuelType s_FuelTypeForCar = eFuelType.Octan96;
        private static float s_MaxTimeForBatteryForCar = 4.8f;
        private static int s_NumberOfTiresForMotorBike = 2;
        private static float s_MaxTirePressureForBike = 28f;
        private static float s_MaxFuelForBike = 5.5f;
        private static eFuelType s_FuelTypeForBike = eFuelType.Octan95;
        private static float s_MaxTimeForBatteryForBike = 1.6f;
        private static int s_NumberOfTiresForMotorTruck = 16;
        private static float s_MaxTirePressureForTruck = 30f;
        private static float s_MaxFuelForTruck = 105f;
        private static eFuelType s_FuelTypeForTruck = eFuelType.Soler;

        public static Car CreateCar(eTypeOfVeichle i_TypeOfVeichile)
        {
            Car car = null;
            switch (i_TypeOfVeichile)
            {
                case eTypeOfVeichle.FuelCar:
                    car = new FuelCar(s_FuelTypeForCar, s_MaxFuelForCar);
                    car.Tires = initTires(s_NumberOfTiresForCar, s_MaxTirePressureForCar);
                    break;

                case eTypeOfVeichle.ElectricCar:
                    car = new ElectricCar(s_MaxTimeForBatteryForCar);
                    car.Tires = initTires(s_NumberOfTiresForCar, s_MaxTirePressureForCar);
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
                    motorBike.Tires = initTires(s_NumberOfTiresForMotorBike, s_MaxTirePressureForBike);
                    break;

                case eTypeOfVeichle.ElectricMotorCycle:
                    motorBike = new ElectricMotorBike(s_MaxTimeForBatteryForBike);
                    motorBike.Tires = initTires(s_NumberOfTiresForMotorBike, s_MaxTirePressureForBike);
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
                    truck.Tires = initTires(s_NumberOfTiresForMotorTruck, s_MaxTirePressureForTruck);
                    break;
            }

            return truck;
        }

        private static List<Tire> initTires(int i_NumberOfTires, float i_MaxPressure)
        {
            List<Tire> tires = new List<Tire>();

            for (int i = 0; i < i_NumberOfTires; i++)
            {
                tires.Add(new Tire(i_MaxPressure));
            }

            return tires;
        }
    }
}
