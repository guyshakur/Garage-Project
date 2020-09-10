using System;
using Ex03.GarageLogic;
using Ex03.GarageLogic.Enums;
using Ex03.GarageLogic.Garage;

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
                                break;
                            }
                    }
                }
            } while (true);
        }

        private static string mainMenuChoice()
        {
            Console.Clear();
            Console.WriteLine(
@"         Garage
in any location if you press on key 'Q' you return to main menu
please choose your choice:
1. Add veichle to the Garage
2. Get List of all liecence in the garage
3. Change status of car by Liecence Id
4. Inflate tires
5. Fuel Car with gas
6. Charge Battery
7. Get full info about veichle by liecence ID");
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

        private static bool isStringContainsOnlyNumerics(string i_String)
        {
            bool isStringOnlyNumerics = true;
            foreach (char c in i_String)
            {
                if (!char.IsDigit(c))
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
                if (!char.IsLetter(c) && c != ' ')
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
