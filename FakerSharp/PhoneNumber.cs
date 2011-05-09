using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FakerSharp
{
	public class PhoneNumber : Base<PhoneNumber>
	{
		public static string Number
		{
			get
			{
				return Numerify(TypeFetch("Formats"));
			}
		}
	}
}
