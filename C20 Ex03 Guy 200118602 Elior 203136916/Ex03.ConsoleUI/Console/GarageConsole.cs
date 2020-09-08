using System;


namespace Ex03.ConsoleUI
{
	public class GarageConsole
	{
		public static void Garage()
		{
			string read;
			do
			{
				read = mainMenuChoice();
				// if (read == "Q" || !int.TryParse(read, out int result) || result < 1 || result > 7)
				checkIfQ(read);
				if (checkReadFromUser(read, 7))
				{
					switch (int.Parse(read))
					{
						case 1:
							{
								AddVeichleToGarageConsole.AddVeichleToGarage();
								break;
							}
						case 2:
							{
								ListOfAllLiecenceInTheGarage.getListOfAllLiecenceInTheGarage();
								break;
							}
							/*  case 3:
								  {
									  changeStatusOfCarByLiecenceId();
									  break;
								  }
							  case 4:
								  {
									  inflateTires();
									  break;
								  }
							  case 5:
								  {
									  fuelCarWithGas();
									  break;
								  }
							  case 6:
								  {
									  7.getFullInfoAboutVeichleByLiecenceID();
									  break;
								  }
							  case 7:
								  {
									  addVeichleToGarage(out fullNameCustomer, out phoneCustomer);
									  break;
								  }*/
					}
				}
			} while (true);
		}



		private static string mainMenuChoice()
		{
			//Console.Clear();
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
			return (int.TryParse(i_Number, out int result) && result >= 1 || result <= i_MaximumNumber);
		}
		public static void checkIfQ(string i_input)
		{
			if (i_input.Contains("Q"))
			{
				Garage();
			}
		}
	}

}
