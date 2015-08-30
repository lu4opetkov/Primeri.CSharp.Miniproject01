using System;

namespace Calculations
{
	public class Formula05
	{
		private Colors.ForCLI _cl = new Colors.ForCLI();

		public Formula05 ()
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
				}else{
						if(param.Length != 5){badcommand();}
						else
						{
							double result = 0;
							if (runCalculate (param, out result))
							{
								_cl.Default();	Console.Write("Обемът на канален изкоп е: ");
								_cl.Result();	Console.Write(result.ToString("N2") );
								_cl.Default();	Console.WriteLine(" m3\n");
							}
							else{	}
						}
					}
				}catch{
			}
		}

		private bool runCalculate (string [] _param, out double _result)
		{
			try {
				double a = 0 ,b = 0, h = 0, l = 0;
				if (Double.TryParse (_param [1], out a) &&
					Double.TryParse (_param [2], out b) &&
					Double.TryParse (_param [3], out h) &&
					Double.TryParse (_param [4], out l))
				{
					_result = (a +b )/2 * h * l ;
					return true;
				}else{badcommand();}

			} catch {
			}

			_result = 0;
			return false;

		}

		private void help ()
		{
			_cl.Result();	Console.Write ("[кизкоп]");
			_cl.Default(); Console.WriteLine(" - канален изкоп");

			_cl.Command(); Console.Write (" параметри");
			_cl.Default(); Console.WriteLine(" - a,b,h  и l");

			_cl.Command();Console.Write (" a и b ");
			_cl.Default();Console.WriteLine(" - горна и долна ширина на профила");

			_cl.Command();Console.Write (" h и l ");
			_cl.Default();Console.WriteLine(" - височина и дължина на профила\n");

		}
		private void badcommand()
		{
			_cl.Default(); Console.Write("Има грешно въведени параметри. Може \nда проверите синтаксиса с параметъра -п \n\n");
		}
	}
}

