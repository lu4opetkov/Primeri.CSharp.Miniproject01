using System;

namespace Calculations
{
	/// <summary>
	/// Клас за формула за обикновена строителна яма(Формула 1)	</summary>
	public class Formula01
	{
		//Библиотеки
		private Colors.ForCLI _c = new Colors.ForCLI();
		public Formula01 () // Формула за обикновена строителна яма
		{
		}
		//Парсване
		public void calc (string _userInput)
		{
			try {
				string[] param = _userInput.Split (' ');
				if (param.Length > 1 && _userInput.Contains ("-п")) 
				{
					help();
				}else{
					if (param.Length > 1 && param.Length != 6 ) {badcommand();}
					else
					{
						//Изчисления
						double _result = 0;
						if (runCalculations(param, out _result))
						{
							_c.Default(); Console.Write("Обема на строителната яма е: " );
							_c.Result(); Console.Write (_result.ToString("N2") );
							_c.Default(); Console.WriteLine(" м3\n\n");
						}
					}
				}

			} catch {
			}
		}
			//Изчисления и изписване
		private bool runCalculations (string[] _param, out double _result)
		{
				try
				{
					double _a1= 0, _b1 =0, _a2 = 0, _b2=0, _h=0 ;

				//param[0] == <име на команда>
				if( Double.TryParse(_param[1], out _a1) &&
					Double.TryParse(_param[2], out _b1) &&
					Double.TryParse(_param[3], out _a2) &&
					Double.TryParse(_param[4], out _b2) &&
					Double.TryParse(_param[5], out _h))
						{
						double F1 = _a1 * _b1, F2=_a2*_b2;
						_result= _h * (F1+F2)/2;
						return true;
						}
				else{ badcommand();}
				}catch{
						}
						_result = 0;

						return false;
			
		}
		//Помощ за командата
		private void help ()
		{
			_c.Default(); Console.Write("[яма]");
			_c.Result(); Console.WriteLine(" - команда за пресмятане на строителна яма");

			_c.Command(); Console.Write(" параметри: ");
			_c.Result(); Console.WriteLine(" a1 b1 a2 b2 h \n");

			_c.Command(); Console.Write(" a1 и b1 ");
			_c.Result(); Console.WriteLine(" - ширина и дължина на горната страна на изкопа");

			_c.Command(); Console.Write(" a2 и b2 ");
			_c.Result(); Console.WriteLine(" - ширина и дължина на долната страна на изкопа");

			_c.Command(); Console.Write(" h ");
			_c.Result(); Console.WriteLine(" - дълбочина на изкопа \n");
		}
		public void badcommand()
		{
			_c.Default(); Console.WriteLine("Има грешно въведени параметри. Може\nда проверите синтаксиса с параметъра -п \n\n");
		}
	}
}


