using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FakerSharp
{
	public class Address : Base<Address>
	{
		public static string City
		{
			get
			{
				return new[]{
					string.Format("{0} {1}{2}", CityPrefix, Name.FirstName, CitySuffix),
					string.Format("{0} {1}", CityPrefix, Name.FirstName),
					string.Format("{0}{1}", Name.FirstName, CitySuffix),
					string.Format("{0}{1}", Name.LastName, CitySuffix)
				}.Pick();
			}
		}

		public static string StreetName
		{
			get
			{
				return new StringGenerator[]{
					() => string.Join(" ", Name.FirstName, StreetSuffix),
					() => string.Join(" ", Name.LastName, StreetSuffix)
				}.Pick()();
			}
		}

		public static string StreetAddress
		{
			get
			{
				return Numerify(string.Format("{0} {1}", TypeFetch("StreetAddress"), StreetName));
			}
		}

		public static string StreetAddressWithSecondary
		{
			get
			{
				return Numerify(string.Format("{0} {1} {2}", TypeFetch("StreetAddress"), StreetName, SecondaryAddress));
			}
		}

		public static string SecondaryAddress
		{
			get { return Numerify(TypeFetch("SecondaryAddress")); }
		}

		public static string ZipCode
		{
			get { return Bothify(TypeFetch("Postcode")).ToUpper(); }
		}

		public static string Zip { get { return ZipCode; } }
		public static string Postcode { get { return ZipCode; } }

		public static string StreetSuffix
		{
			get { return TypeFetch("StreetSuffix"); }
		}

		public static string CitySuffix
		{
			get { return TypeFetch("CitySuffix"); }
		}

		public static string CityPrefix
		{
			get { return TypeFetch("CityPrefix"); }
		}

		public static string StateAbbr
		{
			get { return TypeFetch("StateAbbr"); }
		}

		public static string State
		{
			get { return TypeFetch("State"); }
		}

		public static string Country
		{
			get { return TypeFetch("Country"); }
		}
	}
}
