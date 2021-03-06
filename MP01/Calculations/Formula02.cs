﻿using System;

namespace Calculations
{
	public class Formula02 
	{
		Colors.ForCLI _cl = new Colors.ForCLI();

		//Формула за вдлъбнат ъгъл
	public Formula02 ()
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
						if (param.Length != 4){
							badcommand ();}
						else 
							{
								double result = 0;
								if (runCalculate (param, out result)) 
								{
									_cl.Default ();
									Console.Write ("Обемът на вдлъбнатият ъгъл е: ");
									_cl.Result ();
									Console.Write (result.ToString ("N2"));
									_cl.Default ();
									Console.WriteLine (" m3\n");
								}
							}
				}
			
			}catch{
			}
		}

		private bool runCalculate (string [] _param, out double _result)
		{
			try {
				double a = 0, b = 0,h = 0;
				if(			
					Double.TryParse (_param [1], out a) &&
					
					Double.TryParse (_param [2], out b) &&
					
					Double.TryParse (_param [3], out h)) 
				{

				_result = (a * b * h) / 3;
				return true;
				}else{badcommand();}
			} catch {
				
			}

			_result = 0;
			return false;
		
		}


		private void help ()
		{
			_cl.Result();	Console.Write ("[въгъл]");
			_cl.Default(); Console.WriteLine(" - вдлъбнат ъгъл");

			_cl.Command(); Console.Write (" параметри");
			_cl.Default(); Console.WriteLine(" - a, b  и h");

			_cl.Command();Console.Write (" a и b");
			_cl.Default();Console.WriteLine(" - ширина и дължина");

			_cl.Command();Console.Write (" h");
			_cl.Default();Console.WriteLine(" - височина\n");

		}
		private void badcommand()
		{
			_cl.Default(); Console.Write("Има грешно въведени параметри. Може \n да проверите синтаксиса с параметъра -п \n\n");
		}
	}
}

