using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FakerSharp
{
	public class Company : Base<Company>
	{
		public static readonly StringGenerator[] FORMATS = new StringGenerator[]{
			() => string.Join(" ", FakerSharp.Name.LastName, Suffix),
			() => string.Join("-", FakerSharp.Name.LastName, FakerSharp.Name.LastName),
			() => string.Format("{0}, {1} and {2}", FakerSharp.Name.LastName, FakerSharp.Name.LastName, FakerSharp.Name.LastName)
		};

		public static string Suffix
		{
			get { return TypeFetch("Suffix"); }
		}

		public static string Name
		{
			get { return FORMATS.Pick()(); }
		}

		public static string CatchPhrase
		{
			get
			{
				return string.Join(" ", TypeFetch("CatchPhrase1"), TypeFetch("CatchPhrase2"), TypeFetch("CatchPhrase3"));
			}
		}

		public static string BS
		{
			get
			{
				return string.Join(" ", TypeFetch("BS1"), TypeFetch("BS2"), TypeFetch("BS3"));
			}
		}
	}
}
