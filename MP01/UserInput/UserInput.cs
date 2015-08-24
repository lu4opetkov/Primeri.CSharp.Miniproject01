using System;

namespace UserInput
{
	public class UInput
	{
		public UInput ()
		{
		}
		public void getUserCommands ()
		{
			string command = "";
			do {
				// Взимане на команда
				Console.Write("$ ");
				command = Console.ReadLine();

				// Проверка за налични команди

				if (command.ToLower().Contains("команда1"))  Console.WriteLine("Стартирана е команда 1");
				if (command.ToLower().Contains("команда2"))  Console.WriteLine("Стартирана е команда 2");
				if (command.ToLower().Contains("команда3"))  Console.WriteLine("Стартирана е команда 3");	

			} while (command.ToLower() != "изход");
		}


		public void justTesting ()
		{
			Console.WriteLine ("Стартиране на UserInput.UInput.justTesting()");
		}
	}
}

