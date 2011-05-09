using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FakerSharp
{
	public class Name : Base<Name>
	{
		public static string FullName
		{
			get
			{
				return new Regex(@":(.+?)(?:[ ]|$)").Replace(TypeFetch("Formats"), match => TypeFetch(match.Groups[1].ToString()) + " ").Trim();
			}
		}

		public static string FirstName
		{
			get { return TypeFetch("FirstName"); }
		}

		public static string LastName
		{
			get { return TypeFetch("LastName"); }
		}

		public static string Prefix
		{
			get { return TypeFetch("Prefix"); }
		}

		public static string Suffix
		{
			get { return TypeFetch("Suffix"); }
		}
	}
}
