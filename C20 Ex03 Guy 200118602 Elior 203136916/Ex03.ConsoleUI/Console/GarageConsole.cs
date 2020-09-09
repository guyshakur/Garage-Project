﻿using Ex03.GarageLogic;
using Ex03.GarageLogic.Enums;
using Ex03.GarageLogic.Garage;
using System;

namespace Ex03.ConsoleUI
{
    public class GarageConsole
    {
        public static void StartGarageConsole()
        {
            string read;
            do
            {
                read = mainMenuChoice();
                // if (read == "Q" || !int.TryParse(read, out int result) || result < 1 || result > 7)
                //checkIfQ(read);
                if (checkReadFromUser(read, 7))
                {
                    switch (int.Parse(read))
                    {
                        case 1:
                            {
                                AddVeichleToGarageConsole.AddVeichleToGarageMenu();
                                break;
                            }
                        case 2:
                            {
                                DetaileOfVeichle.getListOfAllLiecenceInTheGarage();
                                break;
                            }
                        case 3:
                            {
                                FixVeichle.ChangeVehicleStatus();
                                break;
                            }
                        case 4:
                            {
                                FixVeichle.inflateTires();
                                break;
                            }
                        case 5:
                            {
                                FixVeichle.fuelCarWithGas();
                                break;
                            }
                        case 6:
                            {
                                FixVeichle.chargeBattery();
                                break;
                            }
                        case 7:
                            {
                                DetaileOfVeichle.getFullInfoAboutVeichleByLiecenceID();
                                //addVeichleToGarage(out fullNameCustomer, out phoneCustomer);
                                break;
                            }
                    }
                }
            } while (true);
        }



        private static string mainMenuChoice()
        {
            Console.Clear();
            Console.WriteLine("     Garage");
            Console.WriteLine("in any location if you press on key 'Q' you return to main menu");
            Console.WriteLine("please choose your choice:\n" +
                "1. Add veichle to the Garage\n" +
                "2. Get List of all liecence in the garage\n" +
                "3. Change status of car by Liecence Id\n" +
                "4. Inflate tires\n" +
                "5. Fuel Car with gas\n" +
                "6. Charge Battery\n" +
                "7. Get full info about veichle by liecence ID\n");
            return Console.ReadLine();
        }
        public static bool checkReadFromUser(string i_Number, int i_MaximumNumber)
        {
            int result;
            return (int.TryParse(i_Number, out result) && (result >= 1 && result <= i_MaximumNumber));
        }
        public static void checkIfQ(string i_input)
        {
            if (i_input.Contains("Q"))
            {
                StartGarageConsole();
            }
        }

        public static eTypeOfVeichle AddVeichleToGarageMenu()
        {
            string phoneNumber, fullName;
            string licenceID, model, tiresModel;
            float currentGazAmountOrHoursLeftForBattery, tiresCurrentPressure, capacity = 0;
            int intColor, intDoorsType, readTypeOfVeicle, intLicenceType;
            bool conrainsIsDanger = false;
            eColors color = eColors.Gray;
            eDoorsType doorType = eDoorsType.Two;
            eLiecenceType liecenceType = eLiecenceType.A;
            Garage garage = new Garage();
            Console.Clear();
            readTypeOfVeicle = int.Parse(addVeichleChoice());
            Console.WriteLine("Please enter licence id of the car:");
            licenceID = Console.ReadLine();

            if (!Garage.IsLicenceIDExistInGarage(licenceID))
            {
                do
                {
                    Console.WriteLine("Please enter your full name.(only letters)");
                    fullName = Console.ReadLine();
                } while (String.IsNullOrWhiteSpace(fullName) || isStringContainsNumsOrSigns(fullName));

                do
                {
                    Console.WriteLine("Please enter your phone number(numbers only no spaces)");
                    phoneNumber = Console.ReadLine();
                } while (String.IsNullOrWhiteSpace(phoneNumber) || !isStringContainsOnlyNumerics(phoneNumber));

                Console.WriteLine("Please enter Model of the car");
                model = Console.ReadLine();
                do
                {
                    if ((eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelCar ||           //1
                        (eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelMotorCycle ||    //3
                        (eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.Truck)               //5
                    {
                        Console.WriteLine("Please enter current gas amount of the car (Numeric)");
                    }
                    else                                                                        //2,4
                    {
                        Console.WriteLine("Please enter current hours lefft for battery of the car (numeric)");
                    }
                } while (!float.TryParse(Console.ReadLine(), out currentGazAmountOrHoursLeftForBattery));
                Console.WriteLine("please enter Tires Model of the car");
                tiresModel = Console.ReadLine();
                do
                {
                    Console.WriteLine("Please enter Tires Current pressure of the car (numeric)");
                } while (!float.TryParse(Console.ReadLine(), out tiresCurrentPressure));
                if ((eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelCar ||           //1
                    (eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.ElectricCar)         //2
                {
                    do
                    {
                        Console.WriteLine("Please enter Color of the car\ngrey->1, green->2, white->3 , red->4");
                    } while (!(int.TryParse(Console.ReadLine(), out intColor) && intColor >= 1 && intColor <= 4));
                    color = (eColors)intColor;
                }
                else if ((eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelMotorCycle ||   //3
                    (eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.ElectricMotorCycle)      //4
                {
                    do
                    {
                        Console.WriteLine("Please enter licence type of the car\nA->1, A1->2, B1->3 , B2->4");
                    } while (!(int.TryParse(Console.ReadLine(), out intLicenceType) && intLicenceType >= 1 && intLicenceType <= 4));
                    liecenceType = (eLiecenceType)intLicenceType;
                }
                else                                                                            //5
                {
                    string read;
                    do
                    {
                        Console.WriteLine("Please enter Does contains danger matirials(Y/N)");
                        read = Console.ReadLine();
                    } while (!(read == "y" || read == "Y" || read == "n" || read == "N"));
                    conrainsIsDanger = read == "Y" || read == "y";
                }
                if ((eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelCar ||           //1
                    (eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.ElectricCar)         //2
                {
                    do
                    {
                        Console.WriteLine("Please enter doors type of the car(between 2-5)");
                    } while (!((int.TryParse(Console.ReadLine(), out intDoorsType)) && intDoorsType >= 2 && intDoorsType <= 5));
                    doorType = (eDoorsType)(intDoorsType - 1);
                }
                else                                                                        //3,4,5
                {
                    do
                    {
                        Console.WriteLine("Please enter engine capacity of the car(cc)");

                    } while (!(float.TryParse(Console.ReadLine(), out capacity)));
                }
                try
                {
                    if ((eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelCar ||           //1
                        (eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.ElectricCar)         //2
                    {
                        garage.AddCarAndFillWithDetails((eTypeOfVeichle)readTypeOfVeicle, licenceID,
                            model, currentGazAmountOrHoursLeftForBattery, tiresModel, tiresCurrentPressure,
                            color, doorType);
                        Console.WriteLine("added a new car is succeess");
                    }
                    else if ((eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.FuelMotorCycle ||   //3
                    (eTypeOfVeichle)readTypeOfVeicle == eTypeOfVeichle.ElectricMotorCycle)          //4
                    {
                        garage.AddMotorAndFillWithDetails((eTypeOfVeichle)readTypeOfVeicle,
                            licenceID, model, currentGazAmountOrHoursLeftForBattery,
                            tiresModel, tiresCurrentPressure, liecenceType, (int)capacity);
                        Console.WriteLine("added a new motorecycle is succeess");
                    }
                    else                                                                            //5
                    {
                        garage.AddTruckAndFillWithDetails(eTypeOfVeichle.Truck, licenceID,
                            model, currentGazAmountOrHoursLeftForBattery, tiresModel,
                            tiresCurrentPressure, conrainsIsDanger, capacity);
                        Console.WriteLine("added a new truck is succeess");
                    }
                    garage.AddCustomer(fullName, phoneNumber, licenceID);
                }
                catch (ValueOutOfRangeException ex)
                {
                    Console.WriteLine(
@"

");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(
@"added a new car/motorcycle/truck is failed.
to try again press any key");
                    Console.ReadLine();
                    AddVeichleToGarageMenu();
                }
            }
            else
            {
                Console.WriteLine("The Licence ID is exists - changing the status vehicle to FIXED");
            }
            Console.WriteLine("for exit to main menu press any key");
            Console.ReadLine();
            return (eTypeOfVeichle)readTypeOfVeicle;
        }

        private static bool isStringContainsOnlyNumerics(string i_String)
        {
            bool isStringOnlyNumerics = true;
            foreach (char c in i_String)
            {
                if (!Char.IsDigit(c))
                {
                    isStringOnlyNumerics = false;
                    break;
                }
            }
            return isStringOnlyNumerics;
        }


        private static bool isStringContainsNumsOrSigns(string i_String)
        {
            bool isContainsNumberOrSigns = false;
            foreach (char c in i_String)
            {
                if (!Char.IsLetter(c) && c != ' ')
                {
                    isContainsNumberOrSigns = true;
                }
            }
            return isContainsNumberOrSigns;
        }

        private static string addVeichleChoice()
        {
            string readFromUser;
            do
            {
                Console.Clear();
                Console.WriteLine(
@"     Add Veichle To Garage
in any location if you press on key 'Q' you return to main menu
Please choose:
1. Fuel Car
2. Electric Car
3. Fuel MotorCycle
4. Electric MotorCycle
5. Truck");

                readFromUser = Console.ReadLine();
                GarageConsole.checkIfQ(readFromUser);
            } while (!GarageConsole.checkReadFromUser(readFromUser, 5));
            return readFromUser;

        }
    }

}
              