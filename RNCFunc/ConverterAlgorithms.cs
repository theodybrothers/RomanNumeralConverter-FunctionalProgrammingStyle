using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNCFunc
{
	public static class ConverterAlgorithms
	{
		public static string Ones(int number)
		{
			int onesToConvert = number % 10;

			string conversion = string.Empty;

			int i = 1;

			while (i <= onesToConvert)
			{
				if (i == 4)
					conversion = "IV";
				else if (i == 5)
					conversion = "V";
				else if (i == 9)
					conversion = "IX";
				else
					conversion += "I";
				i++;
			}

			return conversion;
		}

		public static string Tens(int number)
		{
			int tensToConvert = (number % 100) / 10;

			string conversion = string.Empty;

			int i = 1;

			while (i <= tensToConvert)
			{
				if (i == 4)
					conversion = "XL";
				else if (i == 5)
					conversion = "L";
				else if (i == 9)
					conversion = "XC";
				else
					conversion += "X";
				i++;
			}

			return conversion;
		}

		public static string Hundreds(int number)
		{
			int hundredsToConvert = (number % 1000) / 100;

			string conversion = string.Empty;
			int i = 1;

			while (i <= hundredsToConvert)
			{
				if (i == 4)
					conversion = "CD";
				else if (i == 5)
					conversion = "D";
				else if (i == 9)
					conversion = "CM";
				else
					conversion += "C";
				i++;
			}

			return conversion;
		}

		public static string Thousands(int number)
		{
			int thousandsToConvert = number / 1000;

			string conversion = string.Empty;
			int i = 1;

			while (i <= thousandsToConvert)
			{
				conversion += "M";
				i++;
			}

			return conversion;
		}
	}
}
