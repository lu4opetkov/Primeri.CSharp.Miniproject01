using System;

namespace Calculations
{
	public class Formula04
		{
		private Colors.ForCLI _cl = new Colors.ForCLI();

		public Formula04 ()
		{
		}
		public void calc (string _input)
		{
			try
			{
				string[] param = _input.Split(' ');
				if(param.Length >1 && _input.ToLower().Contains ("-п") )
				{
					help();
				}
				if(param.Length != 4){badcommand();}
				else
				{
					double result = 0;
					if (runCalculate (param, out result))
					{
						_cl.Default();	Console.Write("Обемът на страничен ъгъл е: ");
						_cl.Result();	Console.Write(result.ToString("N2") );
						_cl.Default();	Console.WriteLine(" m3\n");
					}
					else{	}
				}
			}catch{
			}
		}

		private bool runCalculate (string [] _param, out double _result)
		{
			try {
				double a = 0, h = 0, l = 0;
				if (Double.TryParse (_param [1], out a) &&
					Double.TryParse (_param [2], out h) &&
					Double.TryParse (_param [3], out l))
				{
					_result = a * h /2 * l ;
					return true;
				}else{badcommand();}

			} catch {
			}

			_result = 0;
			return false;

		}

		private void help ()
		{
			_cl.Result();	Console.Write ("[съгъл]");
			_cl.Default(); Console.WriteLine(" - страничен ъгъл");

			_cl.Command(); Console.Write (" параметри");
			_cl.Default(); Console.WriteLine(" - a, h  и l");

			_cl.Command();Console.Write (" a и h ");
			_cl.Default();Console.WriteLine(" - ширина и височина на профила");

			_cl.Command();Console.Write (" l ");
			_cl.Default();Console.WriteLine(" - дължина на профила");

		}
		private void badcommand()
		{
			_cl.Default(); Console.Write("Има грешно въведени параметри. Може \nда проверите синтаксиса с параметъра -п \n\n");
		}
	}
}
