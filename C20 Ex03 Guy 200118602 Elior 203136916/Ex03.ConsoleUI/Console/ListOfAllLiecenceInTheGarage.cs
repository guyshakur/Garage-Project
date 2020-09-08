using System;
using Ex03.GarageLogic.Garage;

namespace Ex03.ConsoleUI
{
	class ListOfAllLiecenceInTheGarage
	{
		public static void getListOfAllLiecenceInTheGarage()
		{
			Garage garage = new Garage();
			if (Garage.GetAllLiecenceAndStatus().Length == 0)
			{
				Console.WriteLine("You have no vehicle in the garage yet");
			}
			else 
			{
				Console.WriteLine(Garage.GetAllLiecenceAndStatus().ToString());
			}
		}
	}
}
