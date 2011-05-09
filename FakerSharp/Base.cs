using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;

namespace FakerSharp
{
	public abstract class Base {
		private static readonly char[] LETTERS = "abcdefghijklmnopqrstuwxyz".ToArray();

		protected static Random random = new Random();

		/// <summary>
		/// Receives a string and replace the number placeholders with actual numbers
		/// </summary>
		/// <param name="numberString">A string containing number placeholders</param>
		/// <returns>the original string with the placeholders replaced</returns>
		/// <example>
		/// <![CDATA[
		/// string phoneNumber = "(###) ###-####";
		/// string actualPhone = Base.Numerify(phoneNumber);
		/// // actuaPhone = (587) 683-7755
		/// ]]>
		/// </example>
		protected static string Numerify(string numberString)
		{
			var regex = new Regex(@"#");
			return regex.Replace(numberString, match => random.Next(10).ToString());
		}

		protected static string Letterify(string letterString)
		{
			var regex = new Regex(@"\?");
			return regex.Replace(letterString, match => LETTERS[random.Next(LETTERS.Length)].ToString());
		}

		protected static string Bothify(string str)
		{
			return Letterify(Numerify(str));
		}

		protected static string Fetch(string key)
		{
			return Properties.Strings.ResourceManager.GetString(key).Split(',').Select(e => e.Trim()).Pick();
		}
	}

	public abstract class Base<TChild> : Base
		where TChild : Base
	{
		protected static string TypeFetch(string key)
		{
			return Fetch(string.Format("{0}{1}", typeof(TChild).Name, key));
		}
	}

	public delegate string StringGenerator();
}
