using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace InfWeb.FakerSharp
{
	public abstract class Base
	{
		private static readonly char[] LETTERS = "abcdefghijklmnopqrstuwxyz".ToArray();

		private static Random random = new Random();
		protected static string Numerify(string numberString)
		{
			var regex = new Regex(@"#");
			return regex.Replace(numberString, (match) => random.Next(10).ToString());
		}

		protected static string Letterify(string letterString)
		{
			var regex = new Regex(@"\?");
			return regex.Replace(letterString, (match) => LETTERS[random.Next(LETTERS.Length)].ToString());
		}

		protected static string Bothify(string str)
		{
			return Letterify(Numerify(str));
		}
	}
}
