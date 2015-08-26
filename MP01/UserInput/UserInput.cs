using System;

namespace UserInput
{
	public class UInput

	{
		Colors.ForCLI _c = new Colors.ForCLI();
		About.Me about = new About.Me ();

		public void sayHello ()
		{
			_c.Default (); Console.WriteLine ("Добре дошли в " + about._shortName + "\n" + about._version +"\n");
		}
		public UInput ()
		{
			
		}
		public void getUserCommands ()
		{
			string command = "";
			do {
				// Взимане на команда
				_c.Prompt();  Console.Write("$ ");
				_c.Command(); command = Console.ReadLine();

				// Проверка за налични команди

				if (command.ToLower().Contains("команда1"))  
				{
					_c.Default ();
					Console.Write("Стартирана е ");
					_c.Command ();
					Console.WriteLine("команда 1\n");

				}
				if (command.ToLower().Contains("команда2"))  Console.WriteLine("Стартирана е команда 2\n");

				if (command.ToLower().Contains("команда3"))  Console.WriteLine("Стартирана е команда 3\n");	

			} while (command.ToLower() != "изход");
		}



		public void justTesting ()
		{
			Console.WriteLine ("Стартиране на UserInput.UInput.justTesting()");
		}
	}
}

