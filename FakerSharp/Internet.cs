using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FakerSharp
{
	public class Internet : Base<Internet>
	{
		private static Converter<string, string> getInternetName = (str) => new Regex(@"\W").Replace(str, "").ToLower();

		public static string GetEmail() { return GetEmail(null); }
		public static string GetEmail(string name)
		{
			return string.Join("@", GetUserName(name), DomainName);
		}

		public static string GetFreeEmail() { return GetFreeEmail(null); }
		public static string GetFreeEmail(string name)
		{
			return string.Join("@", GetUserName(name), TypeFetch("FreeEmail"));
		}

		public static string GetUserName() { return GetUserName(null); }

		public static string GetUserName(string name)
		{
			string[] separators = new[] { ".", " ", "_" };
			if (name != null)
			{
				var parts = from part in new Regex(@"(\w+)").Split(name)
							where !string.IsNullOrWhiteSpace(part)
							select part;
				return string.Join(separators.Pick(), parts).ToLower();
			}

			return new StringGenerator[]{
				() => getInternetName(Name.FirstName),
				() => string.Join(separators.Pick(), new[]{ Name.FirstName, Name.LastName }.Select(n => getInternetName(n)))
			}.Pick()();
		}

		public static string DomainName
		{
			get { return string.Join(".", DomainWord, DomainSuffix); }
		}

		public static string DomainWord
		{
			get { return getInternetName(Company.Name.Split(' ').First()); }
		}

		public static string DomainSuffix
		{
			get { return TypeFetch("DomainSuffix"); }
		}

		public static string IPv4Address
		{
			get
			{
				int max = 255;
				return string.Join(".", random.Next(2, max), random.Next(2, max), random.Next(2, max), random.Next(2, max));
			}
		}

		public static string IPv6Address
		{
			get
			{
				string[] container = new string[8];
				int max = 65535;
				for (int i = 0; i < container.Length; i++)
					container[i] = random.Next(max).ToString("X");
				return string.Join(":", container);
			}
		}
	}
}
