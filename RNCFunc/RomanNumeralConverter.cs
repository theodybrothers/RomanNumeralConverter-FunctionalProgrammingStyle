using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNCFunc
{
	public class RomanNumeralConverter
	{
		private List<Func<int, string>> _converters;

		public RomanNumeralConverter()
		{
			_converters = new List<Func<int, string>>
			{
				ConverterAlgorithms.Thousands,
				ConverterAlgorithms.Hundreds,
				ConverterAlgorithms.Tens,
				ConverterAlgorithms.Ones
			};
		}

		public string ConvertToRomanNumerals(int number)
		{
			if (number <= 0 || number > 3000)
				return "Invalid value";

			string result = string.Empty;

			_converters.ForEach(x => result += x(number));

			return result;
		}
	}
}
