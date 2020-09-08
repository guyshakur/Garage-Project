using System;
using Ex03.GarageLogic.Garage;

namespace Ex03.ConsoleUI
{
	class ListOfAllLiecenceInTheGarage
	{
		public static void getListOfAllLiecenceInTheGarage()
		{
			Garage garage = new Garage();
			if (garage.GetAllLiecenceAndStatus().Length == 0)
			{
				Console.WriteLine("You have no vehicle in the garage yet");
			}
			else 
			{
				Console.WriteLine(garage.GetAllLiecenceAndStatus().ToString());
			}
		}
	}
}
