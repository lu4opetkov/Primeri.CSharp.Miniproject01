using System;

namespace UserInput
{
	public class UInput

	{
		Colors.ForCLI _c = new Colors.ForCLI();
		About.Me about = new About.Me ();
		Calculations.MainLibrary _calc = new Calculations.MainLibrary ();

		public void sayHello ()
		{
			_c.Default (); Console.WriteLine ("Добре дошли в " + about._shortName + "\n" + about._version +"\n");
		}
		public UInput ()
		{
			
		}
		public void getUserCommands ()
		{
			string _command = "";
			do {
				// Взимане на команда
				_c.Prompt();  Console.Write("$ ");
				_c.Command(); _command = Console.ReadLine();

				// Проверка за налични команди

				if (_command.ToLower().Contains("яма"))    _calc.F01.calc(_command);
				if (_command.ToLower().Contains("въгъл"))  _calc.F02.calc(_command);
				if (_command.ToLower().Contains("иъгъл"))  _calc.F03.calc(_command);	
				if (_command.ToLower().Contains("съгъл"))  _calc.F04.calc(_command);

				if (_command.ToLower().Contains("помощ") || 
					_command.ToLower() == "п") 				 _calc.commands();
				if (_command.ToLower().Contains("изчисти") || 
					_command.ToLower() == "и")   
				{
					Console.Clear();
					Console.WriteLine("Добре дошли в " + about._shortName + "\n" + about._version);
				}


			} while (_command.ToLower() != "изход");
		}



		public void justTesting ()
		{
			Console.WriteLine ("Стартиране на UserInput.UInput.justTesting()");
		}
	}
}

