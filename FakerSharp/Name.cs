using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace InfWeb.FakerSharp
{
	public class Name : Base
	{
		public static string Name
		{
			get
			{
				return new Regex(@":(.+?)(?:[ ]|$)").Replace(TypeFetch("Formats"), match => TypeFetch(match.Groups[0].ToString()));
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
			get { return TypeFetch("NamePrefix"); }
		}

		public static string Suffix
		{
			get { return TypeFetch("NameSuffix"); }
		}
	}
}
